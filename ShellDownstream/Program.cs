using System;

using Akka.Actor;

using VisionSuite.Actors.Root;
using VisionSuite.Actors.Root.Presentation;
using VisionSuite.Messages.Core;

namespace VisionSuite.ShellDownstream
{
    class Program
    {
        static void Main(string[] args)
        {
            ActorSystem rootActorSystem = ActorSystem.Create("ShellDownstreamRoot");
            var builder = new RootActorBuilder()
                .Version(new Version(1, 1))
                .Presentation(new PresentationActorBuilder().WithName("Presentation Actor"));
            var rootActor = builder.Build(rootActorSystem);

            rootActor.Tell(new ShowVersionMessage());

            //Wait for the moment user hits any key just for test purposes
            Console.ReadKey();
            rootActorSystem.Shutdown();
        }
    }
}
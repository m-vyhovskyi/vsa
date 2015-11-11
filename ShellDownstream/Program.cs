using System;

using Akka.Actor;

using VisionSuite.ActorBuilders;

namespace VisionSuite.ShellDownstream
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ActorSystem rootActorSystem = ActorSystem.Create("ShellDownstreamRoot");            
            var builder = new ApplicationActorBuilder();
            builder.Build(rootActorSystem);

            //Wait for the moment user hits any key just for test purposes
            Console.ReadKey();
            rootActorSystem.Shutdown();
        }
    }
}
using System;

using Akka.Actor;

using Autofac;

using VisionSuite.Actors;
using VisionSuite.Actors.Root;
using VisionSuite.Actors.Root.Presentation;
using VisionSuite.Messages.Core;

namespace VisionSuite.ShellDownstream
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ManageContainer();
            using (var scope = container.BeginLifetimeScope())
            {
                var presentation = scope.Resolve<IPresentationActorBuilder>();
                var rootActorBuilder = scope.Resolve<IRootActorBuilder>();

                ActorSystem rootActorSystem = ActorSystem.Create("ShellDownstreamRoot");
                
                var builder = rootActorBuilder
                    .Version(new Version(1, 1))
                    .Presentation(presentation.Name("Presentation Actor"));

                var rootActor = builder.Build(RootBuilderContext.From(rootActorSystem));

                rootActor.Tell(new ShowVersionMessage());

                //Wait for the moment user hits any key just for test purposes
                Console.ReadKey();
                rootActorSystem.Shutdown();                
            }
        }

        private static IContainer ManageContainer()
        {
            var builder = new ContainerBuilder();
            ActorRepository.ConfigureWith(builder);
            return builder.Build();
        }
    }
}
using System;

using Akka.Actor;

using Autofac;

using VisionSuite.Actors.Configuration.Root;
using VisionSuite.Actors.Configuration.Root.Presentation;
using VisionSuite.Messages.Core;

using ShellDownstreamActorRepository = ShellDownstream.Actors.ActorRepository;
using VisionSuiteActorRepository = VisionSuite.Actors.ActorRepository;

namespace VisionSuite.ShellDownstream
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ManageContainer();
            using (var scope = container.BeginLifetimeScope())
            {
                //var presentation = scope.Resolve<IPresentationActorBuilder>();
                //var rootActorBuilder = scope.Resolve<IRootActorBuilder>();

                var rootActorSystem = ActorSystem.Create("ShellDownstreamRoot");

                var builder = Configuration.Root.GetBuilder();
                //var builder = rootActorBuilder
                //    .Version(new Version(1, 1))
                //    .Presentation(presentation.Name("Presentation Actor"));

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
            VisionSuiteActorRepository.ConfigureWith(builder);
            ShellDownstreamActorRepository.ConfigureWith(builder);
            return builder.Build();
        }
    }
}
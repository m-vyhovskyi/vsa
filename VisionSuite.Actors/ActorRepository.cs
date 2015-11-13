using Autofac;

using VisionSuite.Actors.Root;
using VisionSuite.Actors.Root.Presentation;

namespace VisionSuite.Actors
{
    public static class ActorRepository
    {
        public static void ConfigureWith(ContainerBuilder builder)
        {
            builder.RegisterType<RootActorBuilder>().As<IRootActorBuilder>();
            builder.RegisterType<PresentationActorBuilder>().As<IPresentationActorBuilder>();
        }
    }
}
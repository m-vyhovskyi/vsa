using Autofac;

using ShellDownstream.Actors.Configuration.Root;

using VisionSuite.Actors.Configuration.Root;

namespace ShellDownstream.Actors
{
    public static class ActorRepository
    {
        public static void ConfigureWith(ContainerBuilder builder)
        {
            //builder.RegisterType<ShellDownstreamRootActorBuilder>().As<IRootActorBuilder>();
        }
    }
}
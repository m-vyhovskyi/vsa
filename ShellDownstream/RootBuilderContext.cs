using Akka.Actor;

using VisionSuite.Actors;

namespace VisionSuite.ShellDownstream
{
    public class RootBuilderContext : IBuilderContext
    {
        public static RootBuilderContext From(IActorRefFactory factory)
        {
            return new RootBuilderContext(factory);
        }

        private readonly IActorRefFactory factory;

        private RootBuilderContext(IActorRefFactory factory)
        {
            this.factory = factory;
        }

        public IActorRef ActorOf(Props props, string name = null)
        {
            return factory.ActorOf(props, name);
        }
    }
}
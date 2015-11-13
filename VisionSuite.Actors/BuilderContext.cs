using Akka.Actor;

namespace VisionSuite.Actors
{
    public class BuilderContext : IBuilderContext
    {
        public static BuilderContext From(IUntypedActorContext context)
        {
            return new BuilderContext(context);
        }

        private readonly IUntypedActorContext context;

        private BuilderContext(IUntypedActorContext context)
        {
            this.context = context;
        }

        public IActorRef ActorOf(Props props, string name = null)
        {
            return context.ActorOf(props, name);
        }
    }
}
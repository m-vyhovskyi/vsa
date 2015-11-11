using Akka.Actor;

using VisionSuite.Actors;

namespace VisionSuite.ActorBuilders
{
    public abstract class ActionBuilder<T> : IActorBuilder<T>
        where T : IActor, new()
    {
        protected abstract T OnPostBuild(T actor);

        public T Build(IActorRefFactory actorRefFactory)
        {
            
            IActorRef actor = actorRefFactory.ActorOf(Props.Create(typeof(T)));
            return OnPostBuild(actor);
        }
    }
}
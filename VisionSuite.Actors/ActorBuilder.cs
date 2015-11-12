using System;

using Akka.Actor;

namespace VisionSuite.Actors
{
    public abstract class ActorBuilder<T> : IActorBuilder<T>
        where T : IActor
    {
        protected abstract Action<T, IUntypedActorContext> OnBuild(IActorRefFactory actorRefFactory);

        public IActorRef Build(IActorRefFactory actorRefFactory)
        {
            var buildAction = OnBuild(actorRefFactory);
            AsssertBuildAction(buildAction);
            return actorRefFactory.ActorOf(Props.Create(typeof(T), buildAction));
        }

        private void AsssertBuildAction(Action<T,IUntypedActorContext> buildAction)
        {
            if (buildAction == null)
            {
                throw new ArgumentNullException("Build action hasn't been supplied");
            }
        }
    }
}
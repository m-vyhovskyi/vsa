using System;

using Akka.Actor;

namespace VisionSuite.Actors
{
    public abstract class ActorBuilder<T> : IActorBuilder<T>
        where T : IActor
    {
        protected abstract Action<T> OnBuild();

        public IActorRef Build(IActorRefFactory actorRefFactory)
        {
            var buildAction = OnBuild();
            AsssertBuildAction(buildAction);
            return actorRefFactory.ActorOf(Props.Create(typeof(T), buildAction));
        }

        private void AsssertBuildAction(Action<T> buildAction)
        {
            if (buildAction == null)
            {
                throw new ArgumentNullException("Build action hasn't been supplied");
            }
        }
    }
}
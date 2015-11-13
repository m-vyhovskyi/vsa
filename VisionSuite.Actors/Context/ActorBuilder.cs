using System;

using Akka.Actor;

namespace VisionSuite.Actors.Context
{
    public abstract class ActorBuilder<T> : IActorBuilder<T>
        where T : IActor
    {
        protected abstract Action<T, IBuilderContext> OnBuild();

        public IActorRef Build(IBuilderContext context)
        {
            var buildAction = OnBuild();
            AsssertBuildAction(buildAction);

            return context.ActorOf(Props.Create(typeof(T), buildAction));
        }

        private void AsssertBuildAction(Action<T,IBuilderContext> buildAction)
        {
            if (buildAction == null)
            {
                throw new ArgumentNullException("Build action hasn't been supplied");
            }
        }
    }
}
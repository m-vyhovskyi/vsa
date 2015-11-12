using System;

using Akka.Actor;

namespace VisionSuite.Actors.Root.Presentation
{
    public class PresentationActorBuilder : ActorBuilder<PresentationActor>
    {
        private string name;

        public PresentationActorBuilder WithName(string name)
        {
            this.name = name;
            return this;
        }

        protected override Action<PresentationActor,IUntypedActorContext> OnBuild(IActorRefFactory actorRefFactory)
        {
            return (a,c) =>
            {
                a.Name = name;
            };
        }
    }
}
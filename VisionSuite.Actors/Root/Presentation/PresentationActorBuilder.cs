using System;

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

        protected override Action<PresentationActor> OnBuild()
        {
            return (a) =>
            {
                a.Name = name;
            };
        }
    }
}
using System;

namespace VisionSuite.Actors.Root.Presentation
{
    class PresentationActorBuilder : ActorBuilder<PresentationActor>, IPresentationActorBuilder
    {
        private string name;

        public IPresentationActorBuilder Name(string name)
        {
            this.name = name;
            return this;
        }
        
        protected override Action<PresentationActor, IBuilderContext> OnBuild()
        {
            return (a, c) => { a.Name = name; };
        }
    }

}
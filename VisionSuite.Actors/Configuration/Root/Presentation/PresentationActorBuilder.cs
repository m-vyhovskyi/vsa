using System;

using VisionSuite.Actors.Context;
using VisionSuite.Actors.Root.Presentation;

namespace VisionSuite.Actors.Configuration.Root.Presentation
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

    public interface IPresentationActorBuilder : IActorBuilder<PresentationActor>
    {
        IPresentationActorBuilder Name(string name);

    }

}
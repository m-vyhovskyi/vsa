using System;

using VisionSuite.Actors.Root.Presentation;

namespace VisionSuite.Actors.Root
{
    class RootActorBuilder : ActorBuilder<RootActor>, IRootActorBuilder
    {
        private Version version;
        private IPresentationActorBuilder presentationBuilder;

        public RootActorBuilder(IPresentationActorBuilder presentationActorBuilder)
        {
            presentationBuilder = presentationActorBuilder;
        }

        public IRootActorBuilder Version(Version version)
        {
            this.version = version;
            return this;
        }

        public IRootActorBuilder Presentation(IPresentationActorBuilder presentationBuilder)
        {
            this.presentationBuilder = presentationBuilder;
            return this;
        }

        protected override Action<RootActor, IBuilderContext> OnBuild()
        {
            return (a, context) =>
            {
                a.Version = version;
                a.Presentation = presentationBuilder.Build(context);
            };
        }
    }
}
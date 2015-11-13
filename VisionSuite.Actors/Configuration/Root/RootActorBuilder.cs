using System;

using VisionSuite.Actors.Configuration.Root.Presentation;
using VisionSuite.Actors.Context;
using VisionSuite.Actors.Root;

namespace VisionSuite.Actors.Configuration.Root
{
    public interface IRootActorBuilder : IActorBuilder<RootActor>
    {
        IRootActorBuilder Version(Version version);

        IRootActorBuilder Presentation(IPresentationActorBuilder presentationBuilder);
    }

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
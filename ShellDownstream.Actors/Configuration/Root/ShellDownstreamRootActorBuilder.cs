using System;

using ShellDownstream.Actors.Root;

using VisionSuite.Actors.Configuration.Root;
using VisionSuite.Actors.Configuration.Root.Presentation;
using VisionSuite.Actors.Context;

namespace ShellDownstream.Actors.Configuration.Root
{
    public interface IShellDownstreamRootActorBuilder : IActorBuilder<ShellDownstreamRootActor>
    {
        IRootActorBuilder Version(Version version);

        IRootActorBuilder Presentation(IPresentationActorBuilder presentationBuilder);
    }

    class ShellDownstreamRootActorBuilder : ActorBuilder<ShellDownstreamRootActor>, IRootActorBuilder
    {
        private Version version;
        private IPresentationActorBuilder presentationBuilder;

        public ShellDownstreamRootActorBuilder(IPresentationActorBuilder presentationActorBuilder)
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

        protected override Action<ShellDownstreamRootActor, IBuilderContext> OnBuild()
        {
            return (a, context) =>
            {
                a.Version = version;
                a.Presentation = presentationBuilder.Build(context);
            };
        }
    }
}
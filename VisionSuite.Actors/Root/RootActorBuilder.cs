using System;

using Akka.Actor;

using VisionSuite.Actors.Presentation;
using VisionSuite.Actors.Root.Presentation;

namespace VisionSuite.Actors.Root
{
    public class RootActorBuilder : ActorBuilder<RootActor>
    {
        private Version version;
        private PresentationActorBuilder presentationBuilder;

        public RootActorBuilder()
        {
            presentationBuilder = new PresentationActorBuilder();
        }

        public RootActorBuilder Version(Version version)
        {
            this.version = version;
            return this;
        }

        public RootActorBuilder Presentation(PresentationActorBuilder presentationBuilder)
        {
            this.presentationBuilder = presentationBuilder;
            return this;
        }

        protected override Action<RootActor,IUntypedActorContext> OnBuild(IActorRefFactory actorRefFactory)
        {
            return (a,c) =>
            {
                a.Version = version;
                a.Presentation = presentationBuilder.Build(actorRefFactory);
            };
        }
    }
}
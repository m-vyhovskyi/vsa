using System;

namespace VisionSuite.Actors.Root
{
    public class RootActorBuilder : ActorBuilder<RootActor>
    {
        private Version version;

        public RootActorBuilder OfVersion(Version version)
        {
            this.version = version;
            return this;
        }

        protected override Action<RootActor> OnBuild()
        {
            return (a) =>
            {
                a.Version = version;
            };
        }
    }
}
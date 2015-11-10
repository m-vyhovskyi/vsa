using System;

using Akka.Actor;

using VisionSuite.Actors.Actors;
using VisionSuite.Actors.Builders;

namespace VisionSuite.Root.Configuration
{
    internal class VisionSuiteApplicationActorBuilder : IActorBuilder<VisionSuiteApplicationActor>
    {
        private Version version;

        public VisionSuiteApplicationActorBuilder WithVersion(Version visionSuiteVersion)
        {
            version = visionSuiteVersion;
            return this;
        }

        public VisionSuiteApplicationActor Build(IActorRefFactory actorRefFactory)
        {

            return new VisionSuiteApplicationActor(version);   
        }
    }
}
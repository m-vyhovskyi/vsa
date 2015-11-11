using System;

using Akka.Actor;

using VisionSuite.Actors;

namespace VisionSuite.ActorBuilders
{
    public class ApplicationActorBuilder : IActorBuilder<ApplicationActor>
    {
        private Version version;

        public ApplicationActorBuilder WithVersion(Version visionSuiteVersion)
        {
            version = visionSuiteVersion;
            return this;
        }

        public ApplicationActor Build(IActorRefFactory actorRefFactory)
        {

            return new ApplicationActor(version);   
        }
    }
}
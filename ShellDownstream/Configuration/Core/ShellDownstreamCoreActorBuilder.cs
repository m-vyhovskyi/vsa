using Akka.Actor;

using VisionSuite.Actors.Actors.Core;
using VisionSuite.Actors.Builders;

namespace VisionSuite.Root.Configuration.Core
{
    public class ShellDownstreamCoreActorBuilder : IActorBuilder<VisionSuiteCoreActor>
    {
        public VisionSuiteCoreActor Build(IActorRefFactory actorRefFactory)
        {
            return new VisionSuiteCoreActor();
        }
    }
}
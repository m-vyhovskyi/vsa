using Akka.Actor;

using VisionSuite.Actors.Core;

namespace VisionSuite.ActorBuilders.Core
{
    public class VisionSuiteCoreActorBuilder : IActorBuilder<CoreActor>
    {
        public CoreActor Build(IActorRefFactory actorRefFactory)
        {
            return new CoreActor();
        }
    }
}
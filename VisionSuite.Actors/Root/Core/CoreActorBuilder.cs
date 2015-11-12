using System;

using Akka.Actor;

namespace VisionSuite.Actors.Root.Core
{
    public class CoreActorBuilder : ActorBuilder<CoreActor>
    {
        protected override Action<CoreActor,IUntypedActorContext> OnBuild(IActorRefFactory actorRefFactory)
        {
            return (a,c) =>
            {
                
            };
        }
    }
}
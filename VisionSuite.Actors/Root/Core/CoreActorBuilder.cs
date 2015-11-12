using System;

namespace VisionSuite.Actors.Root.Core
{
    public class CoreActorBuilder : ActorBuilder<CoreActor>
    {
        protected override Action<CoreActor> OnBuild()
        {
            return (a) =>
            {
                
            };
        }
    }
}
using System;

using Akka.Actor;

using VisionSuite.Root.Configuration;

namespace VisionSuite.Root
{
    internal static class VisionSuiteBuilder
    {
        public static void Build(ActorSystem rootActorSystem)
        {
            //collect all builder parts from all the classes
            var vs = new VisionSuiteApplicationActorBuilder()
                .WithVersion(new Version(1, 1));
                
            var rootActor = vs.Build(rootActorSystem);

        }
    }
}
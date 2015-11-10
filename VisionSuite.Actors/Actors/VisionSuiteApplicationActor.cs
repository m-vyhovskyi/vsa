using System;

using Akka.Actor;

namespace VisionSuite.Actors.Actors
{
    public class VisionSuiteApplicationActor : ReceiveActor, IVisionSuiteActor
    {
        public Version Version { get; private set; }

        public VisionSuiteApplicationActor(Version version)
        {
            Version = version;
            
        }
    }
}
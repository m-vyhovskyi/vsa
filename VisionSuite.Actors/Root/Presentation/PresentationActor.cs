using System;

using Akka.Actor;

namespace VisionSuite.Actors.Root.Presentation
{
    public class PresentationActor : ReceiveActor, IActor
    {
        public string Name { get; set; }

        public PresentationActor(Action<PresentationActor> build)
        {
            build(this);
        }
    }
}
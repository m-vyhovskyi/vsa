using System;

using Akka.Actor;

using VisionSuite.Messages.Core;

namespace VisionSuite.Actors.Root.Presentation
{
    public class PresentationActor : ReceiveActor, IActor
    {
        public string Name { get; set; }

        public PresentationActor(Action<PresentationActor, IUntypedActorContext> build)
        {
            build(this, Context);
            Receive<ShowVersionMessage>(m => ProcessShowVersion(m));
        }

        private void ProcessShowVersion(ShowVersionMessage showVersionMessage)
        {
            Console.WriteLine("Name is {0}", Name);
        }
    }
}
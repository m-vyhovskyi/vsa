using System;

using Akka.Actor;

using VisionSuite.Messages.Core;

namespace VisionSuite.Actors.Root
{
    public class RootActor : ReceiveActor, IActor
    {
        public Version Version { get; set; }

        public IActorRef Presentation { get; set; }

        public RootActor(Action<RootActor, IUntypedActorContext> build)
        {
            build(this, Context);
            Receive<ShowVersionMessage>(m => ProcessShowVersion(m));
        }

        private void ProcessShowVersion(ShowVersionMessage showVersionMessage)
        {
            Console.WriteLine("Version is {0}", Version);
            Presentation.Tell(showVersionMessage);
        }
    }
}
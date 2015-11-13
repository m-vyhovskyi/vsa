using System;

using Akka.Actor;

using VisionSuite.Actors.Context;
using VisionSuite.Messages.Core;

namespace ShellDownstream.Actors.Root
{
    public class ShellDownstreamRootActor : ReceiveActor, IActor
    {
        public Version Version { get; set; }

        public IActorRef Presentation { get; set; }

        public ShellDownstreamRootActor(Action<ShellDownstreamRootActor, IBuilderContext> build)
        {
            build(this, BuilderContext.From(Context));
            Receive<ShowVersionMessage>(m => ProcessShowVersion(m));
        }

        private void ProcessShowVersion(ShowVersionMessage showVersionMessage)
        {
            Console.WriteLine("SHD Version is {0}", Version);
            Presentation.Tell(showVersionMessage);
        }
    }
}
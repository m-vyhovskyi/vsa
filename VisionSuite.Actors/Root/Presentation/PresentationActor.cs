using System;

using Akka.Actor;

using VisionSuite.Actors.Context;
using VisionSuite.Messages.Core;

namespace VisionSuite.Actors.Root.Presentation
{
    public class PresentationActor : ReceiveActor, IActor
    {
        public string Name { get; set; }

        public PresentationActor(Action<PresentationActor, IBuilderContext> build)
        {
            build(this, BuilderContext.From(Context));
            Receive<ShowVersionMessage>(m => ProcessShowVersion(m));
        }

        private void ProcessShowVersion(ShowVersionMessage showVersionMessage)
        {
            Console.WriteLine("Name is {0}", Name);
        }
    }
}
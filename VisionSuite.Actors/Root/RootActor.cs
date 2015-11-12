using System;

using Akka.Actor;

using VisionSuite.Messages.Core;

namespace VisionSuite.Actors.Root
{
    public class RootActor : ReceiveActor, IActor
    {
        public Version Version { get; set; }

        public RootActor(Action<RootActor> build)
        {
            build(this);
            Receive<ShowVersionMessage>(m => Console.WriteLine("Version is {0}", Version));
        }
    }
}
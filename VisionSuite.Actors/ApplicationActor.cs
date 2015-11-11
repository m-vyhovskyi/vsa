using System;

using Akka.Actor;

namespace VisionSuite.Actors
{
    public class ApplicationActor : ReceiveActor, IActor
    {
        public Version Version { get; private set; }

        public ApplicationActor(IActorBuilder<ApplicationActor> actorBuilder)
        {
            Props.
            actorBuilder.Build(this, Context);
        }
    }
}
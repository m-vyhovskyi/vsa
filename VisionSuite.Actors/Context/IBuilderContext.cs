using Akka.Actor;

namespace VisionSuite.Actors.Context
{
    public interface IBuilderContext
    {
        IActorRef ActorOf(Props props, string name = null);
    }
}
using Akka.Actor;

namespace VisionSuite.Actors
{
    public interface IBuilderContext
    {
        IActorRef ActorOf(Props props, string name = null);
    }
}
using Akka.Actor;

namespace VisionSuite.Actors
{
    public interface IActorBuilder<T> where T: IActor
    {
        IActorRef Build(IActorRefFactory actorRefFactory);
    }
}
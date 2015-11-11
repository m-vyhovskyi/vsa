using Akka.Actor;

namespace VisionSuite.Actors
{
    public interface IActorBuilder<T> where T: IActor
    {
        T Build(T actor, IActorRefFactory actorRefFactory);
    }
}
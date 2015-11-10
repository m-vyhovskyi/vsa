using Akka.Actor;

using VisionSuite.Actors.Actors;

namespace VisionSuite.Actors.Builders
{
    public interface IActorBuilder<out T> where T: IVisionSuiteActor
    {
        T Build(IActorRefFactory actorRefFactory);
    }
}
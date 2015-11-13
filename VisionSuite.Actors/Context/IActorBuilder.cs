using Akka.Actor;

namespace VisionSuite.Actors.Context
{
    public interface IActorBuilder<T> where T: IActor
    {
        IActorRef Build(IBuilderContext context);
    }
}
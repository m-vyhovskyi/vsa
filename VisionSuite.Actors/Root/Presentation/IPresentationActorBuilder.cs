namespace VisionSuite.Actors.Root.Presentation
{
    public interface IPresentationActorBuilder: IActorBuilder<PresentationActor>
    {
        IPresentationActorBuilder Name(string name);

    }
}
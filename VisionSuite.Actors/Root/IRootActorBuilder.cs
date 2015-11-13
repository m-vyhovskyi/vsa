using System;

using VisionSuite.Actors.Root.Presentation;

namespace VisionSuite.Actors.Root
{
    public interface IRootActorBuilder : IActorBuilder<RootActor>
    {
        IRootActorBuilder Version(Version version);
        IRootActorBuilder Presentation(IPresentationActorBuilder presentationBuilder);
    }
}
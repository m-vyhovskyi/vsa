using System;

using VisionSuite.Actors.Configuration.Root.Presentation;

namespace VisionSuite.Actors.Configuration.Root
{
    public interface IRootConfiguration
    {
        Version Version { get; set; }
        IPresentationConfiguration Presentation { get; set; }

        IRootActorBuilder GetBuilder();
    }

    public class RootConfiguration : IRootConfiguration
    {
        public Version Version { get; set; }
        public IPresentationConfiguration Presentation { get; set; }

        public IRootActorBuilder GetBuilder()
        {
            var presentationBuilder = Presentation.GetBuilder();
            return new RootActorBuilder(presentationBuilder)
                .Version(Version);
        }
    }
}
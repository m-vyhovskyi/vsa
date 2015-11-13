using System;

using VisionSuite.Actors.Configuration.Root;
using VisionSuite.Actors.Configuration.Root.Presentation;

namespace VisionSuite.ShellDownstream
{
    internal static class Configuration
    {
        public static IRootConfiguration Root
        {
            get { return GetConfiguration(); }
        }

        private static IRootConfiguration GetConfiguration()
        {
            return new RootConfiguration
            {
                Version = new Version(1, 1),
                Presentation = new PresentationConfiguration
                {
                    Name = "Presented in a new way"
                }
            };
        }
    }
}
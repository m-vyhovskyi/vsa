namespace VisionSuite.Actors.Configuration.Root.Presentation
{
    public class PresentationConfiguration: IPresentationConfiguration
    {
        /// <summary>
        /// Name that is visible at the top of the window.
        /// </summary>
        public string Name { get; set; }

        public IPresentationActorBuilder GetBuilder()
        {
            return new PresentationActorBuilder();
        }
    }

    public interface IPresentationConfiguration
    {
        string Name { get; set; }

        IPresentationActorBuilder GetBuilder();
    }
}
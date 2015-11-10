using Akka.Actor;

namespace VisionSuite.Root
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ActorSystem system = ActorSystem.Create("VisionSuiteRoot");
            VisionSuiteBuilder.Build(system);
        }
    }
}
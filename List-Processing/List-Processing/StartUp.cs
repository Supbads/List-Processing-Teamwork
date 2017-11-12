using List_Processing.Core;

namespace List_Processing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var engine = new ProcessingEngine();

            engine.Run();
        }
    }
}
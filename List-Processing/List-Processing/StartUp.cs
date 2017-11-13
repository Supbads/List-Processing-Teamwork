namespace List_Processing
{
    using Core.Models;
    using List_Processing.Core;

    public class StartUp
    {
        public static void Main()
        {
            var logger = new ConsoleLogger();

            var engine = new Engine(logger);

            engine.Run();
        }
    }
}
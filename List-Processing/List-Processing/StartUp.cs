namespace List_Processing
{
    using Core.Models;
    using List_Processing.Core;

    public class StartUp
    {
        public static void Main()
        {
            var logger = new ConsoleLogger();
            var interpreter = new CommandInterpreter(logger);

            var engine = new Engine(logger, interpreter);

            engine.Run();
        }
    }
}
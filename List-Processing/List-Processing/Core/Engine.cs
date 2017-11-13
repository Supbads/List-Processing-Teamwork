namespace List_Processing.Core
{
    using List_Processing.Core.Models;
    using Contracts;

    public class Engine : IEngine
    {
        public CommandExecutor executor;

        public Engine(Logger logger)
        {
            this.executor = new CommandExecutor(logger);
        }

        public void Run()
        {
            this.executor.SeedData();

            while (true)
            {
                
                this.executor.ExecuteCommand();
                
                
            }
        }
    }
}
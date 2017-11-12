namespace List_Processing.Core.Models
{
    using System;
    using Contracts;

    public class Engine : IEngine
    {
        private readonly Data data = new Data();

        public CommandInterpretator Interpretator { get; } = new CommandInterpretator();
        public CommandExecutor Executor { get; } = new CommandExecutor();

        public void Run()
        {
            // first line is the data
            var dataInput = Console.ReadLine();
            var dataparams = this.data.DataParams;

            this.Interpretator.Seed(dataparams, dataInput);

            while (true)
            {
                try
                {
                    // process command
                    var consoleInput = Console.ReadLine();

                    var command = this.Interpretator.ParseCommand(consoleInput);

                    this.Executor.ExecuteCommand(command);

                    //// if this is the right place for printing
                    //HelperCommands.Print(this.data.DataParams);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
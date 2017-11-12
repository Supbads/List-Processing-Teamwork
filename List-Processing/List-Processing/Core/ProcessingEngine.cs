namespace List_Processing.Core
{
    using System;
    using System.Collections.Generic;
    using List_Processing.Helpers;

    public class ProcessingEngine
    {
        private readonly List<string> data = new List<string>();

        private readonly CommandInterpretator interpretator = new CommandInterpretator();

        private readonly CommandExecutor executor = new CommandExecutor();

        public void Run()
        {
            //Main logic goes here
            var dataInput = Console.ReadLine();
            this.interpretator.Seed(this.data, dataInput);
            
            while (true)
            {
                try
                {
                    var consoleInput = Console.ReadLine();

                    var command = this.interpretator.ParseCommand(consoleInput);

                    this.executor.ExecuteCommand(command);
                    HelperCommands.Print(this.data);
                    //Display results or Catch and Exception when invalid parameters/inputs are given

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }                
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace List_Processing.Core
{
    public class ProcessingEngine
    {
        private List<string> data = new List<string>();

        private CommandInterpretator interpretator = new CommandInterpretator();

        private CommandExecutor executor = new CommandExecutor();

        public void Run()
        {
            //Main logic goes here
            var dataInput = Console.ReadLine();
            interpretator.Seed(data, dataInput);
            

            while (true)
            {
                try
                {
                    var consoleInput = Console.ReadLine();

                    var command = interpretator.ParseCommand(consoleInput);

                    executor.ExecuteCommand(command);

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
namespace List_Processing.Core
{
    using List_Processing.Core.Models;
    using Contracts;
    using System.Linq;
    using List_Processing.Helpers;
    using System;

    public class Engine : IEngine
    {
        //private CommandExecutor executor;

        private readonly ICommandInterpreter interpreter;

        private readonly Data data = new Data();

        private Logger logger;

        public Engine(Logger logger, ICommandInterpreter interpreter)
        {
            this.IsRunning = true;

            this.logger = logger;
            this.interpreter = interpreter;

        }

        public bool IsRunning { get; set; }

        public void Run()
        {
            this.SeedData();

            while (IsRunning)
            {
                var output = Utils.AppendData(data.DataParams);
                this.logger.Write(output);

                var commandInput = logger.Read();

                try
                {
                    var command = this.interpreter.ParseCommand(commandInput);
                    command.Execute(this.data);

                    this.IsRunning = !this.data.EndReceived;
                }
                catch (Exception e)
                {
                    logger.Write(e.Message);
                }
            }
        }

        private void SeedData()
        {
            var dataInput = logger.Read();

            data.DataParams.AddRange(dataInput.Split().ToList());

            //var output = Utils.AppendData(data.DataParams);
            //this.logger.Write(output);
        }
    }
}
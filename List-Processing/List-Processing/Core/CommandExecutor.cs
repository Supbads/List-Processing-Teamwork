//namespace List_Processing.Core
//{
//    using System;
//    using List_Processing.Core.Models;
//    using List_Processing.Helpers;

//    public class CommandExecutor
//    {
//        private Logger logger;

//        private readonly CommandInterpreter interpreter;

//        private readonly Data data = new Data();

//        public CommandExecutor(Logger logger)
//        {
//            this.logger = logger;
//            this.interpreter = new CommandInterpreter(logger);
//        }

//        public void SeedData()
//        {
//            var dataInput = logger.Read();

//            interpreter.Seed(data.DataParams, dataInput);

//            var output = Utils.AppendData(data.DataParams);
//            this.logger.Write(output);
//        }

//        public void ExecuteCommand() 
//        {
//            //Main logic for command execution flow
//            try
//            {
//                string commandInput = logger.Read();
//                var command = interpreter.ParseCommand(commandInput);
                
//                command.Execute(this.data);

//                var output = Utils.AppendData(data.DataParams);

//                this.logger.Write(output);
//            }
//            catch (Exception e)
//            {
//                logger.Write(e.Message);

//            }
            
//        }
//    }
//}
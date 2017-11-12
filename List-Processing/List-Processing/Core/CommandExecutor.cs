namespace List_Processing.Core
{
    using List_Processing.Core.Models.Commands;

    public class CommandExecutor
    {
        public void ExecuteCommand(Command command)
        {
            command.Execute();
        }
    }
}
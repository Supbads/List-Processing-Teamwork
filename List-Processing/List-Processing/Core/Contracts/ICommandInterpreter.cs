namespace List_Processing.Core.Contracts
{
    using List_Processing.Core.Models.Commands;

    public interface ICommandInterpreter
    {
        Command ParseCommand(string commandInput);
    }
}

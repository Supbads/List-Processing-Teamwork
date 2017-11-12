namespace List_Processing.Helpers
{
    using System;
    using System.Collections.Generic;

    public static class HelperCommands
    {
        public static void CheckCommand(string input, string reqCommand, int length, int reqLength)
        {
            if (input != reqCommand || length != reqLength)
            {
                throw new InvalidOperationException(Messages.InvalidInput);
            }
        }    

        public static void Print(IEnumerable<string> collection)
        {
            Console.WriteLine(string.Join(", ", collection));
        }
    }
}
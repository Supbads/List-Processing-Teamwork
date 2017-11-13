﻿namespace List_Processing.Core.Models
{
    using List_Processing.Core.Contracts;

    public abstract class Logger : IReader, IWritter
    {
        public abstract string Read();

        public abstract void Write(string line);
    }
}
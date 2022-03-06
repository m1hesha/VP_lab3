using System;

namespace VP_lab3
{
    public class RomanNumberException : Exception
    {
        public RomanNumberException() : base("ERROR") { }
        public RomanNumberException(string message) : base(message) { }
    }
}
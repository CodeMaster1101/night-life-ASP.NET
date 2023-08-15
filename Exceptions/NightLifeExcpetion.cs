using System;

namespace night_life_sk.Exceptions
{
    public class NightLifeException : Exception
    {
        public NightLifeException() { }

        public NightLifeException(string message) : base(message) { }

        public NightLifeException(string message, Exception inner) : base(message, inner) { }
    }
}

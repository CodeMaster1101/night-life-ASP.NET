using System;

namespace night_life_sk.Exceptions
{
    internal class NightLifeException : Exception
    {
        internal NightLifeException() { }

        internal NightLifeException(string message) : base(message) { }

        internal NightLifeException(string message, Exception inner) : base(message, inner) { }
    }
}

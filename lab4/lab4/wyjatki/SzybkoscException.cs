using System;

namespace lab4lib.wyjatki
{
    [Serializable]
    public class SzybkoscException : Exception
    {
        public SzybkoscException()
        {
        }

        public SzybkoscException(string message) : base(message)
        {
        }

        public SzybkoscException(string message, Exception inner) : base(message, inner)
        {
        }

        protected SzybkoscException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
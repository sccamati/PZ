using System;

namespace ClassLibrary.Wyjatki
{
    [Serializable]
    public class TomNumberException : ApplicationException
    {
        public TomNumberException()
        {
        }

        public TomNumberException(string message) : base(message)
        {
        }

        public TomNumberException(string message, Exception inner) : base(message, inner)
        {
        }

        protected TomNumberException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
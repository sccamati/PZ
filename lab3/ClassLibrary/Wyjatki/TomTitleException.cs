using System;

namespace ClassLibrary.Wyjatki
{
    [Serializable]
    public class TomTitileException : ApplicationException
    {
        public TomTitileException()
        {
        }

        public TomTitileException(string message) : base(message)
        {
        }

        public TomTitileException(string message, Exception inner) : base(message, inner)
        {
        }

        protected TomTitileException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
using System;

namespace ClassLibrary.Wyjatki
{
    [Serializable]
    public class DokumentException : ApplicationException
    {
        public DokumentException()
        {
        }

        public DokumentException(string message) : base(message)
        {
        }

        public DokumentException(string message, Exception inner) : base(message, inner)
        {
        }

        protected DokumentException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
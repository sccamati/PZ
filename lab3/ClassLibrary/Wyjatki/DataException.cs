using System;

namespace ClassLibrary.Wyjatki
{


    [Serializable]
    public class DataException : ApplicationException
    {
     
        public DataException()
        {
        }
        public DataException(string message) : base(message)
        {
        }
        public DataException(string message, Exception inner) : base(message, inner)
        { 
        }
        protected DataException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) 
        { 
        }
    }
}
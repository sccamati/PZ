using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7lib
{

    [Serializable]
    public class ManaException : ApplicationException
    {
        public ManaException() { }
        public ManaException(string message) : base(message) { }
        public ManaException(string message, Exception inner) : base(message, inner) { }
        protected ManaException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

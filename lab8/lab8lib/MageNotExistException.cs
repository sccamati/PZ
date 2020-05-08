using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8lib
{

    [Serializable]
    public class MageNotExistException : ApplicationException
    {
        public MageNotExistException() { }
        public MageNotExistException(string message) : base(message) { }
        public MageNotExistException(string message, Exception inner) : base(message, inner) { }
        protected MageNotExistException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

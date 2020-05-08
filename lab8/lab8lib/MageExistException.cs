using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8lib
{

    [Serializable]
    public class MageExistException : ApplicationException
    {
        public MageExistException() { }
        public MageExistException(string message) : base(message) { }
        public MageExistException(string message, Exception inner) : base(message, inner) { }
        protected MageExistException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

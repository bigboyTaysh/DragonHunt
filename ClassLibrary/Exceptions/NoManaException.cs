using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Exceptions
{
    [Serializable]
    public class NoManaException : ApplicationException
    {
        public NoManaException() { }
        public NoManaException(string message) : base(message) { }
        public NoManaException(string message, Exception inner) : base(message, inner) { }
        protected NoManaException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

using System;

namespace ConsoleApplication1.Models.Exception
{
    [Serializable]
    public class RegraException : System.Exception
    {
        public RegraException(string message) : base(message) { }

        protected RegraException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}

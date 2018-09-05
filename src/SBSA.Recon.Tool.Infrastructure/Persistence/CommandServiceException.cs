using System;

namespace SBSA.Recon.Tool.Infrastructure.Persistence
{

    [Serializable]
    public class CommandServiceException : Exception
    {
        public CommandServiceException() { }
        public CommandServiceException(string message) : base(message) { }
        public CommandServiceException(string message, Exception inner) : base(message, inner) { }
        protected CommandServiceException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

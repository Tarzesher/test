using System;

namespace ABSA.OffShore.QueryService.Persistence
{

    [Serializable]
    public class QueryServiceException : Exception
    {
        public QueryServiceException() { }
        public QueryServiceException(string message) : base(message) { }
        public QueryServiceException(string message, Exception inner) : base(message, inner) { }
        protected QueryServiceException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

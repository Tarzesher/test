using System;

namespace SBSA.OffShore.Infrastructure.Service.Exceptions
{
    public class UnregisteredDomainEventException : Exception
    {
        public UnregisteredDomainEventException(string message) : base(message) { }
    }
}

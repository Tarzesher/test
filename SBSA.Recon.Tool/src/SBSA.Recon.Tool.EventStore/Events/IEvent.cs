using System;

namespace SBSA.OffShore.Domain.EventStore.Events
{
    public interface IEvent
    {
        Guid Id { get; }
    }
}

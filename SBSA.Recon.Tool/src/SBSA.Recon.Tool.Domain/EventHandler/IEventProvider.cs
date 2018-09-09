using SBSA.OffShore.Domain.EventStore.Events;
using System.Collections.Generic;

namespace SBSA.OffShore.Domain.EventHandler
{
    public interface IEventProvider
    {
        void LoadsFromHistory(IEnumerable<Event> history);
        IEnumerable<Event> GetUncommittedChanges();
    }
}

using SBSA.OffShore.Domain.EventStore.Events;

namespace SBSA.OffShore.Domain.EventHandler
{
    public interface IEventHandler<TEvent> where TEvent : Event
    {
        void Handle(TEvent handle);
    }
}

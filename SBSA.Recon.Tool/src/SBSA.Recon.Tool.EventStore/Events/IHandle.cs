namespace SBSA.OffShore.Domain.EventStore.Events
{
    public interface IHandle<TEvent> where TEvent: Event
    {
        void Handle(TEvent e);
    }
}

using SBSA.OffShore.Domain.EventStore.Events;

namespace SBSA.Recon.Tool.Domain.Messaging
{
    public interface IEventBus
    {
        void Publish<T>(T @event) where T : Event;
    }
}

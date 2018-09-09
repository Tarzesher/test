using Autofac;
using SBSA.OffShore.Domain.Configuration;
using SBSA.OffShore.Domain.EventHandler;
using SBSA.OffShore.Domain.EventStore.Events;
using SBSA.OffShore.Infrastructure.Service.Exceptions;

namespace SBSA.Recon.Tool.Domain.Messaging
{
    public class EventBus: IEventBus
    {
        private IComponentContext Context { get; set; }

        public EventBus()
        {
             Context = OffshoreContainer.Build();
        }
        
        public void Publish<T>(T @event) where T : Event
        {
            var handler = this.Context.Resolve<IEventHandler<T>>();

            if (handler != null)
            {
                handler.Handle(@event);
            }
            else
            {
                throw new UnregisteredDomainCommandException("no handler registered");
            }
        }
    }
}

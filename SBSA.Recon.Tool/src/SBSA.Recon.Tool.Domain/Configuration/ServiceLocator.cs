using Autofac;
using Microsoft.Extensions.DependencyInjection;
using SBSA.Recon.Tool.Domain.Messaging;

namespace SBSA.OffShore.Domain.Configuration
{
    public sealed class ServiceLocator
    {
        private static ICommandBus _commandBus;
        private static IEventBus _eventBus;

        static ServiceLocator()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging();
      
            _commandBus = OffshoreContainer.Build().Resolve<ICommandBus>();
            _eventBus = OffshoreContainer.Build().Resolve<IEventBus>();
        }

        public static ICommandBus CommandBus
        {
            get { return _commandBus; }
        }

        public static IEventBus EventBus
        {
            get { return _eventBus; }
        }
    }
}

using Autofac;
using Microsoft.Extensions.DependencyInjection;
using SBSA.Recon.Tool.Domain.Messaging;

namespace SBSA.OffShore.Domain.Configuration
{
    public sealed class ServiceLocator
    {
        private static ICommandBus commandBus;
        private static IEventBus eventBus;

        static ServiceLocator()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging();

            commandBus = OffshoreContainer.Build().Resolve<ICommandBus>();
            eventBus = OffshoreContainer.Build().Resolve<IEventBus>();
        }

        public static ICommandBus CommandBus
        {
            get { return commandBus; }
        }

        public static IEventBus EventBus
        {
            get { return eventBus; }
        }
    }
}

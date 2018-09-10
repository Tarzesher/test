using Autofac;
using Microsoft.Extensions.DependencyInjection;
using SBSA.OffShore.CommandService.Commands;
using SBSA.OffShore.Domain.CommandHandlers;
using SBSA.OffShore.Domain.QueryHandlers;
using SBSA.Recon.Tool.Domain.Messaging;
using SBSA.Recon.Tool.Infrastructure.Entities;
using SBSA.Recon.Tool.QueryService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SBSA.OffShore.Domain.Configuration
{
    class OffshoreContainer
    {
        public static IComponentContext Build()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging();

            var builder = new ContainerBuilder();

            // register types 
            builder.RegisterType<EventBus>().As<IEventBus>().InstancePerLifetimeScope();
            builder.RegisterType<CommandBus>().As<ICommandBus>().InstancePerDependency();
            builder.RegisterType<CreateCommentCommandHandler>().As<ICommandHandler<CreateCommentCommand>>();
            builder.RegisterType<ReadQueryStatsHandler>().As<IQueryHandler<ReconStatsQuery, Task<IEnumerable<AdaptivRecon>>>>(); 

           // build container 
           var container = builder.Build();

            return container;

        }

    }
}

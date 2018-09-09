using Autofac;
using SBSA.OffShore.Domain.CommandHandlers;
using SBSA.OffShore.Domain.Configuration;
using SBSA.OffShore.Infrastructure.Service.Exceptions;
using SBSA.Recon.Tool.CommandService;

namespace SBSA.Recon.Tool.Domain.Messaging
{
    public class CommandBus : ICommandBus
    {
        private IComponentContext Context { get; set; }

        public CommandBus()
        {
            Context = OffshoreContainer.Build();
        }

        public void Send<T>(T command) where T : Command
        {
            var handler = this.Context.Resolve<ICommandHandler<T>>();

            if (handler != null)
            {
                handler.Execute(command);
            }
            else
            {
                throw new UnregisteredDomainCommandException("no handler registered");
            }
        }        
    }
}

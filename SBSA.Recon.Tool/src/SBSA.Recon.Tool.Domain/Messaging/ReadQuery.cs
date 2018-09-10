using Autofac;
using SBSA.OffShore.Domain.Configuration;
using SBSA.OffShore.Domain.QueryHandlers;
using SBSA.OffShore.Infrastructure.Service.Exceptions;
using SBSA.Recon.Tool.QueryService;

namespace SBSA.Recon.Tool.Domain.Messaging
{
    public class ReadQuery<T, TResult> where T : IQuery<TResult>,
        IQueryHandler<T, TResult>
    {
        private IComponentContext Context { get; set; }

        public ReadQuery()
        {
            Context = OffshoreContainer.Build();
        }

        public TResult Get()
        {
            var handler = this.Context.Resolve<IQueryHandler<T, TResult>>();

            if (handler != null)
            {
                return handler.Get();
            }
            else
            {
                throw new UnregisteredDomainCommandException("no handler registered");
            }
        }
    }

}

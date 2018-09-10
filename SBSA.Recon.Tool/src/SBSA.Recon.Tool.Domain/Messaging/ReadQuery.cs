using Autofac;
using SBSA.OffShore.Domain.Configuration;
using SBSA.OffShore.Domain.QueryHandlers;
using SBSA.OffShore.Infrastructure.Service.Exceptions;
using SBSA.Recon.Tool.QueryService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SBSA.Recon.Tool.Domain.Messaging
{
    public class ReadQuery<T, TResult> where T : IQuery<IEnumerable<TResult>>,
        IQueryHandler<T, IEnumerable<TResult>>
    {
        private IComponentContext Context { get; set; }

        public ReadQuery()
        {
            Context = OffshoreContainer.Build();
        }

        public async Task<IEnumerable<TResult>> Get()
        {
            var handler = this.Context.Resolve<IQueryHandler<T, IEnumerable<TResult>>>();

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

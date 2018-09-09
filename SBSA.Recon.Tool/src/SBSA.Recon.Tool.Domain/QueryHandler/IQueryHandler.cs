using SBSA.OffShore.CommandService;
using SBSA.Recon.Tool.CommandService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SBSA.OffShore.Domain.QueryHandlers
{
    public interface IQueryHandler<TQuery> where TQuery : Query
    {
        Task<IEnumerable<T>> Execute<T>(TQuery query);
    }
}

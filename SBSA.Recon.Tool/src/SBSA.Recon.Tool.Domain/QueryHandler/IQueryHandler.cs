using SBSA.OffShore.CommandService;
using SBSA.Recon.Tool.CommandService;
using SBSA.Recon.Tool.QueryService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SBSA.OffShore.Domain.QueryHandlers
{
    public interface IQueryHandler<TQuery, T> where TQuery : Query { 
        Task<IEnumerable<T>> Execute(TQuery query);
    }
}

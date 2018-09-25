using SBSA.Recon.Tool.QueryService;
using System.Collections.Generic;

namespace SBSA.OffShore.Domain.QueryHandlers
{
    public interface IQueryHandler<in TQuery, out TResponse> 
        where TQuery : IQuery<TResponse>
    {
        TResponse Get();
        TResponse GetById(int id);
    }


}

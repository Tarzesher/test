using SBSA.Recon.Tool.QueryService;

namespace SBSA.OffShore.Domain.QueryHandlers
{
    public interface IQueryHandler<in TQuery, out TResponse> 
        where TQuery : IQuery<TResponse>
    {
        TResponse Get();
    }
}

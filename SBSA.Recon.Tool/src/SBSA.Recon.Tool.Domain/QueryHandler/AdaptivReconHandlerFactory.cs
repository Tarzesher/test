using ABSA.OffShore.QueryService.Persistence;
using SBSA.OffShore.Domain.QueryHandlers;
using SBSA.Recon.Tool.Infrastructure.Entities;
using SBSA.Recon.Tool.QueryService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SBSA.Recon.Tool.Domain.QueryHandler
{
    public class AdaptivReconHandlerFactory
    {
        private IQueryServiceRepository<AdaptivRecon> _repository;
        public AdaptivReconHandlerFactory(IQueryServiceRepository<AdaptivRecon> repository)
        {
            _repository = repository;
        }

        public IQueryHandler<ReconStatsQuery, Task<IEnumerable<AdaptivRecon>>> Build(ReconStatsQuery query)
        {
            return new ReadQueryStatsHandler(_repository);
        }

    }
}

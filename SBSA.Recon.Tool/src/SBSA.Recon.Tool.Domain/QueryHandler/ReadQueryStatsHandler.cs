using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ABSA.OffShore.QueryService.Persistence;
using AutoMapper;
using SBSA.OffShore.Domain.Configuration;
using SBSA.Recon.Tool.Infrastructure.Entities;
using SBSA.Recon.Tool.QueryService;

namespace SBSA.OffShore.Domain.QueryHandlers
{
    public class ReadQueryStatsHandler : 
            IQueryHandler<ReconStatsQuery, Task<IEnumerable<AdaptivRecon>>>
    {
        private IQueryServiceRepository<AdaptivRecon> _repository;
        public IMapper Mapper
        {
            get
            {
                return new Map().Config.CreateMapper();
            }
        }
        public ReadQueryStatsHandler(IQueryServiceRepository<AdaptivRecon> repository)
        {
            _repository = repository;
        }
        public ReadQueryStatsHandler() { }
        public async Task<IEnumerable<AdaptivRecon>> Get()
        {
            return await _repository.FindAsync();
        }

    }
}

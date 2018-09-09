using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ABSA.OffShore.QueryService.Persistence;
using AutoMapper;
using SBSA.OffShore.Domain.Configuration;
using SBSA.OffShore.Domain.QueryHandlers;
using SBSA.Recon.Tool.Infrastructure.Entities;
using SBSA.Recon.Tool.QueryService;

namespace SBSA.OffShore.Domain.CommandHandlers
{
    public class ReadQueryStatsHandler : IQueryHandler<ReconStatsQuery, AdaptivRecon>
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


        public async Task<IEnumerable<AdaptivRecon>> Execute(ReconStatsQuery query)
        {
            if (query == null)
            {
                throw new ArgumentNullException("query");
            }
            if (_repository == null)
            {
                throw new InvalidOperationException("Repository is not initialized.");
            }
            return await _repository.FindAsync();
        }
    }
}

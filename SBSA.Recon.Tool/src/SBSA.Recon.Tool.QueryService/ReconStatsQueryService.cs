using ABSA.OffShore.QueryService.Persistence;
using AutoMapper;
using SBSA.OffShore.Domain.Configuration;
using SBSA.Recon.Tool.Application.DataTransferObject;
using SBSA.Recon.Tool.Infrastructure.Context;
using SBSA.Recon.Tool.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SBSA.Recon.Tool.QueryService
{
    public class ReconStatsQueryService
    {
        public IMapper Mapper
        {
            get
            {
                return new Map().Config.CreateMapper();
            }
        }

        public async Task<List<AdaptivReconDto>> GetReconStats()
        {
            using (var context = new AdaptivContext())
            {
                var lookupRepository = new QueryServiceRepository<AdaptivRecon>(context);
                var result = await lookupRepository.GetAllAsync();
                return Mapper.Map<IEnumerable<AdaptivRecon>, List<AdaptivReconDto>>(result);
            }
        }
    }
}

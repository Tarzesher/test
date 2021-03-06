﻿using ABSA.OffShore.QueryService.Persistence;
using AutoMapper;
using SBSA.OffShore.Domain.Configuration;
using SBSA.Recon.Tool.Domain.QueryHandler;
using SBSA.Recon.Tool.Infrastructure.Entities;
using SBSA.Recon.Tool.QueryService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SBSA.Recon.Tool.Application.Services
{
    public class AdaptivReconService
    {
        public IMapper Mapper
        {
            get
            {
                return new Map().Config.CreateMapper();
            }
        }

        public async Task<IEnumerable<AdaptivRecon>> GetStats(IQueryServiceRepository<AdaptivRecon> repository)
        {
            var query = new ReconStatsQuery();
            var handler = new AdaptivReconHandlerFactory(repository).Build(query);
            return await handler.Get();
        }



        //public async Task<IEnumerable<AdaptivRecon>> GetStats(IQueryServiceRepository<AdaptivRecon> repository, int id)
        //{
        //    var query = new ReconStatsQuery();
        //    var handler = new AdaptivReconHandlerFactory(repository).Build(query);
        //    return await handler.GetById(id);
        //}


    }
}

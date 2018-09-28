using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABSA.OffShore.QueryService.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SBSA.Recon.Tool.Api.Configuration;
using SBSA.Recon.Tool.Application.DataTransferObject;
using SBSA.Recon.Tool.Application.Mapper;
using SBSA.Recon.Tool.Application.Services;
using SBSA.Recon.Tool.Infrastructure.Context;
using SBSA.Recon.Tool.Infrastructure.Entities;

namespace SBSA.Recon.Tool.WebApi.Controllers
{
    public class StatsController : Controller
    {
        public IMapper Mapper
        {
            get
            {
                return new MapperConfig().Config.CreateMapper();
            }
        }
        [Route("api/[controller]")]
        [HttpGet]
        public async Task<IEnumerable<AdaptivReconDto>> Get()
        {
            using (var context = new AdaptivContext())
            {
                var repo = new QueryServiceRepository<AdaptivRecon>(context);
                var service = new AdaptivReconService();
                var stats = await service.GetStats(repo);
                return Mapper.Map<IEnumerable<AdaptivRecon>, IEnumerable<AdaptivReconDto>>(stats);
            }
        }

        [HttpGet]
        public async Task<AdaptivReconDto> GetOne()
        {
            using (var context = new AdaptivContext())
            {
                var repo = new QueryServiceRepository<AdaptivRecon>(context);
                var service = new AdaptivReconService();
                var stats = (await service.GetStats(repo)).ToList().FirstOrDefault();
                return Mapper.Map<AdaptivRecon, AdaptivReconDto>(stats);
            }
        }

        [HttpGet]
        public async Task<IEnumerable<AdaptivReconDto>> GetBySource(string source, DateTime date)
        {
            using (var context = new AdaptivContext())
            {
                var repo = new QueryServiceRepository<AdaptivRecon>(context);
                var service = new AdaptivReconService();
                var stats = (await service.GetStats(repo))
                    .Where(x => x.Source == source & x.CdsbusinessDate == date);
                return Mapper.Map<IEnumerable<AdaptivRecon>, IEnumerable<AdaptivReconDto>>(stats);
            }
        }
        [Route("api/[controller]/GetSourceLookup")]
        [HttpGet]
        public async Task<IEnumerable<string>> GetSourceLookup()
        {
            using (var context = new AdaptivContext())
            {
                var repo = new QueryServiceRepository<AdaptivRecon>(context);
                var service = new AdaptivReconService();
                var stats = (await service.GetStats(repo))
                    .Select(x => x.Source).Distinct();
                return stats;
            }
        }
        [Route("api/[controller]/GetItemsInSource")]
        [HttpGet]
        public async Task<IEnumerable<AdaptivReconDto>> GetItemsInSource(string source, DateTime date, string reconStatus)
        {
            using (var context = new AdaptivContext())
            {
                var repo = new QueryServiceRepository<AdaptivRecon>(context);
                var service = new AdaptivReconService();
                var stats = (await service.GetStats(repo))
                    .Where(x => x.Source == source 
                    & x.CdsbusinessDate == date
                    & x.ItemInSource == reconStatus);
                return Mapper.Map<IEnumerable<AdaptivRecon>, IEnumerable<AdaptivReconDto>>(stats);
            }
        }
        [Route("api/[controller]/GetMiddlewareLogFilter")]
        [HttpGet]
        public async Task<IEnumerable<AdaptivReconDto>> GetMiddlewareLogFilter(string source, DateTime date, string reconStatus)
        {
            using (var context = new AdaptivContext())
            {
                var repo = new QueryServiceRepository<AdaptivRecon>(context);
                var service = new AdaptivReconService();
                var stats = (await service.GetStats(repo))
                    .Where(x => x.Source == source
                    & x.CdsbusinessDate == date
                    & x.MiddlewareLogFilter == reconStatus);
                return Mapper.Map<IEnumerable<AdaptivRecon>, IEnumerable<AdaptivReconDto>>(stats);
            }
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABSA.OffShore.QueryService.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
                return new Map().Config.CreateMapper();
            }
        }
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
        public string read()
        {
            return "Controller";
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SBSA.Recon.Tool.Application.DataTransferObject;
using SBSA.Recon.Tool.Application.Mapper;
using SBSA.Recon.Tool.Application.Services;
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
        public async Task<IEnumerable<AdaptivReconDto>> ReadStats()
        {
            var service = new AdaptivReconService();
            var stats = await service.GetStats();
            return Mapper.Map<IEnumerable<AdaptivRecon>, IEnumerable<AdaptivReconDto>>(stats);
        }
    }
}
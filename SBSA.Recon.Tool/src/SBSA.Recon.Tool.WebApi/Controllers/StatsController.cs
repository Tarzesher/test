using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SBSA.Recon.Tool.Application.DataTransferObject;
using SBSA.Recon.Tool.Application.Services;

namespace SBSA.Recon.Tool.WebApi.Controllers
{
    public class StatsController : Controller
    {
        [HttpGet]
        public async Task<IEnumerable<AdaptivReconDto>> ReadStats()
        {
            var service = new AdaptivReconService();
            return await service.GetStats();
          
        }
    }
}
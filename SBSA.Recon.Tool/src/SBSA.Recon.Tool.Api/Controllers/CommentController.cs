using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABSA.OffShore.QueryService.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SBSA.OffShore.Domain.Configuration;
using SBSA.Recon.Tool.Api.Configuration;
using SBSA.Recon.Tool.Application.DataTransferObject;
using SBSA.Recon.Tool.Application.Services;
using SBSA.Recon.Tool.Infrastructure.Context;
using SBSA.Recon.Tool.Infrastructure.Entities;

namespace SBSA.Recon.Tool.WebApi.Controllers
{
    public class CommentController : Controller
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
        public async Task<IEnumerable<CommentDto>> Get()
        {
            using (var context = new AdaptivContext())
            {
                var repo = new QueryCommentServiceRepository<MetaAdaptivReconComment>(context);
                var service = new CommentsService();
                var comments = await service.GetComments(repo);
                return Mapper.Map<IEnumerable<MetaAdaptivReconComment>, IEnumerable<CommentDto>>(comments);
            }
        }

        [HttpGet]
        public async Task<CommentDto> GetById(int id)
        {
            using (var context = new AdaptivContext())
            {
                var repo = new QueryCommentServiceRepository<MetaAdaptivReconComment>(context);
                var service = new CommentsService();
                var comments = (await service.GetComments(repo))
                    .Where(x=> x.CommentKey == id)
                    .FirstOrDefault();
                return Mapper.Map<MetaAdaptivReconComment, CommentDto>(comments);
            }
        }
        [HttpPost]
        public async void CreateComments(CommentDto dto)
        {
            //dto.Username = HttpContext.User.Identity.Name;
            if (!dto.ApplyToAll)
            {
                var service = new CommentsService();
                await service.AddCommentAsync(dto);
            }
            else
            {
                var commentsService = new CommentsService();
                var controller = new StatsController();
                var stats = (await controller.Get());

                foreach (var s in stats)
                {
                    dto.AdaptivReconId = s.AdaptivReconId;
                    dto.Reference = s.Reference;
                    await commentsService.AddCommentAsync(dto);
                }
               
            }
        }
    }
}
using ABSA.OffShore.QueryService.Persistence;
using AutoMapper;
using SBSA.OffShore.CommandService.Commands;
using SBSA.OffShore.Domain.Configuration;
using SBSA.Recon.Tool.Application.DataTransferObject;
using SBSA.Recon.Tool.Domain.QueryHandler;
using SBSA.Recon.Tool.Infrastructure.Entities;
using SBSA.Recon.Tool.QueryService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SBSA.Recon.Tool.Application.Services
{
    public class CommentsService
    {
        public IMapper Mapper
        {
            get
            {
                return new Map().Config.CreateMapper();
            }
        }

        public async Task<IEnumerable<MetaAdaptivReconComment>> GetComments(IQueryCommentServiceRepository<MetaAdaptivReconComment> repository)
        {
            var query = new CommentQuery();
            var handler = new CommentHandlerFactory(repository).Build(query);
            return await handler.Get();
        }

        public async Task AddCommentAsync(CommentDto dto)
        {
            ServiceLocator.CommandBus.Send(
                new CreateCommentCommand(dto.CommentKey, dto.AdaptivReconId, dto.Reference, 
                dto.ReconStatus, dto.Comments, dto.Username, dto.BusinessDate, dto.CommentDate));
        }
    }
}

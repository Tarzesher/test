using AutoMapper;
using SBSA.OffShore.CommandService.Commands;
using SBSA.OffShore.Domain.Configuration;
using SBSA.Recon.Tool.Application.DataTransferObject;
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

        public async Task CreateComment(CommentDto dto)
        {
            ServiceLocator.CommandBus.Send(
                new CreateCommentCommand(dto.CommentKey,dto.AdaptivReconId, dto.Reference, dto.ReconStatus, 
                dto.Comments,dto.Username, dto.BusinessDate, dto.CommentDate));
        }
    }
}

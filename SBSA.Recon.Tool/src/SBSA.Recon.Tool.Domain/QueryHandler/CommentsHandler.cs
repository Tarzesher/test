using System.Collections.Generic;
using System.Threading.Tasks;
using ABSA.OffShore.QueryService.Persistence;
using AutoMapper;
using SBSA.OffShore.Domain.Configuration;
using SBSA.Recon.Tool.Infrastructure.Entities;
using SBSA.Recon.Tool.QueryService;

namespace SBSA.OffShore.Domain.QueryHandlers
{
    public class CommentsHandler :
           IQueryHandler<CommentQuery, Task<IEnumerable<MetaAdaptivReconComment>>>
    {
        private IQueryCommentServiceRepository<MetaAdaptivReconComment> _repository;
        public IMapper Mapper
        {
            get
            {
                return new Map().Config.CreateMapper();
            }
        }
        public CommentsHandler(IQueryCommentServiceRepository<MetaAdaptivReconComment> repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<MetaAdaptivReconComment>> Get()
        {
            return await _repository.FindAsync();
        }

    }
}

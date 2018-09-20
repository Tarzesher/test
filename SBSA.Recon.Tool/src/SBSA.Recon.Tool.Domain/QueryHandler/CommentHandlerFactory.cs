using ABSA.OffShore.QueryService.Persistence;
using SBSA.OffShore.Domain.QueryHandlers;
using SBSA.Recon.Tool.Infrastructure.Entities;
using SBSA.Recon.Tool.QueryService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SBSA.Recon.Tool.Domain.QueryHandler
{
    public class CommentHandlerFactory
    {
        private IQueryCommentServiceRepository<MetaAdaptivReconComment> _repository;
        public CommentHandlerFactory(IQueryCommentServiceRepository<MetaAdaptivReconComment> repository)
        {
            _repository = repository;
        }

        public IQueryHandler<CommentQuery, Task<IEnumerable<MetaAdaptivReconComment>>> Build(CommentQuery query)
        {
            return new CommentsHandler(_repository);
        }

    }



}

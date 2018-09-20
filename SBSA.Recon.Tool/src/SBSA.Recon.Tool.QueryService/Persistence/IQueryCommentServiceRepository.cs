using SBSA.Recon.Tool.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ABSA.OffShore.QueryService.Persistence
{
    public interface IQueryCommentServiceRepository<T> where T : IReadCommentEntity
    {
        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> FindAsync();
        Task<T> GetByIdAsync(int id);
        Task<ICollection<T>> GetAllAsync();
        Task<int> CountAsync();
    }
}

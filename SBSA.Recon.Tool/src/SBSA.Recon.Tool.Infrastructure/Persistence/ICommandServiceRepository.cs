using SBSA.Recon.Tool.Infrastructure.Common;
using System.Threading.Tasks;

namespace SBSA.Recon.Tool.Infrastructure.Service.Persistence
{
    public interface ICommandServiceRepository<T> where T : IReadCommentEntity
    {
        Task<T> UpdateAsync(T entity);
        Task<int> DeleteAsync(T entity);
        Task<T> AddAsync(T entity);
        Task<T> FindAsync(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SBSA.Recon.Tool.Infrastructure.Common;

namespace ABSA.OffShore.QueryService.Persistence
{
    public class QueryServiceRepository<TEntity>: IQueryServiceRepository<TEntity>
        where TEntity : class, IReadReconEntity
    {
        protected DbContext _context;
        public QueryServiceRepository(DbContext context)
        {
            _context = context;
        }
        public async Task<ICollection<TEntity>> GetAllAsync()
        {
            try
            {
            return await _context
                            .Set<TEntity>()
                            .ToListAsync();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public async Task<IEnumerable<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context
                .Set<TEntity>()
                .Where(predicate)
                .ToListAsync();
        }

       
        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _context
                .Set<TEntity>()
                .FindAsync(id);
        }

        public TEntity GetById(int id)
        {
            return _context
                .Set<TEntity>()
                .Find(id);
        }

        public async Task<int> CountAsync()
        {
            return await _context
                .Set<TEntity>()
                .CountAsync();
        }

        public async Task<IEnumerable<TEntity>> FindAsync()
        {
            return await _context
                .Set<TEntity>()
                .ToListAsync();
        }
    }

}

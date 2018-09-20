using System;
using System.Threading.Tasks;
using SBSA.Recon.Tool.Infrastructure.Common;
using SBSA.Recon.Tool.Infrastructure.Persistence;
using SBSA.Recon.Tool.Infrastructure.Context;

namespace SBSA.Recon.Tool.Infrastructure.Service.Persistence
{
    public class CommandServiceRepository<TEntity> : ICommandServiceRepository<TEntity>
        where TEntity : class, IReadCommentEntity
    {
        protected Microsoft.EntityFrameworkCore.DbContext _context;
        public CommandServiceRepository()
        {
            _context = new AdaptivContext();
        }
        public async Task<TEntity> UpdateAsync(TEntity updated)
        {
            try
            {
            if (updated == null)
                return null;

            var existing = await _context.Set<TEntity>().FindAsync(updated.CommentKey);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(updated);
                await _context.SaveChangesAsync();
            }
               
                else
                    throw new CommandServiceException($"Missing entity {updated.CommentKey}");

                return existing;

            }

            catch (Exception ex)
            {
                SaveError(ex);
                return null;
            }
           
        }
        public async Task<int> DeleteAsync(TEntity entity)
        {
            var obj = entity;
            _context.Set<TEntity>().Remove(obj);
            return await _context.SaveChangesAsync();
        }
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Add(entity);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                SaveError(ex);
            }
            return entity;
        }

        
        public async Task<TEntity> FindAsync(int id)
        {
            try
            {
                return await _context
                      .Set<TEntity>()
                      .FindAsync(id);
            }
            catch (Exception ex)
            {
                SaveError(ex);
                return null;
            }
            
        }

        private void SaveError(Exception Ex)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw;
            }

        }

    }
}


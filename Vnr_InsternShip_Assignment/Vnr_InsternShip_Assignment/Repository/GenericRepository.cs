using Microsoft.EntityFrameworkCore;
using Vnr_InsternShip_Assignment.Models;

namespace Vnr_InsternShip_Assignment.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class    
    {
        protected readonly VnrInternShipContext _context;
        protected DbSet<T> _dbSet;

        public GenericRepository(VnrInternShipContext context)
        {
            _context = context;
            this._dbSet = _context.Set<T>();
        }   

        public virtual async Task<bool> AddAsync(T entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
                return true;
            }
            catch
            {
                return false;
            }
           
        }

        public virtual async Task<bool> DeleteAsync(int? id)
        {
            try
            {
                var entity = await _dbSet.FindAsync(id);
                if (entity != null)
                {
                    _dbSet.Remove(entity);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                var entity = await _dbSet.ToListAsync();
                if (entity != null)
                {
                    return entity;
                }
                return null!;
            }
            catch (Exception ex)
            {
                return null!;
            }
        }

        public async Task<T> GetByIdAsync(int? id)
        {
            try
            {
                var result = await _dbSet.FindAsync(id);
                if (result != null)
                {
                    return result;

                }
                return null!;
            }
            catch (Exception ex)
            {
                return null!;
            }
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            try
            {
                if (entity != null)
                {
                    _context.Entry(entity).State = EntityState.Modified;
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

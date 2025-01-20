using Microsoft.EntityFrameworkCore;
using SchoolManagement.Domain.Common;
using SchoolManagement.Domain.Interfaces;
using SchoolManagement.Infrastructure.Persistence.Context;
using System.Linq.Expressions;

namespace SchoolManagement.Infrastructure.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : AuditableEntity
    {

        protected readonly DbSet<T> _db;
        protected readonly SchoolDbContext _context;


        public BaseRepository(SchoolDbContext context)
        {
            _context = context;
            _db = context.Set<T>();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _db.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _db.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            IQueryable<T> query = _db;

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            return await query.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await _db.FirstOrDefaultAsync(entity => entity.Id == id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}

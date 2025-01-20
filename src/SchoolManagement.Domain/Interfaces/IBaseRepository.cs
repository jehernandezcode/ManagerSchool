
using SchoolManagement.Domain.Common;
using System.Linq.Expressions;

namespace SchoolManagement.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : AuditableEntity
    {
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);
        Task<T?> GetByIdAsync(Guid id);
    }
}

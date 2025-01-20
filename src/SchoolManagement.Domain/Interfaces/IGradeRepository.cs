using System.Linq.Expressions;
using SchoolManagement.Domain.Grades;

namespace SchoolManagement.Domain.Interfaces
{
    public interface IGradeRepository : IBaseRepository<Grade>
    {
        Task<Grade?> GetGradeWithRelationsByIdAsync(Guid gradeId);

        Task<IEnumerable<Grade>> GetAllWithRelationsAsync(Expression<Func<Grade, bool>> filter = null);
    }
}

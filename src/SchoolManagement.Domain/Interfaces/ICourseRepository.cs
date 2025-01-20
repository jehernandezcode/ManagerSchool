using System.Linq.Expressions;
using SchoolManagement.Domain.Courses;

namespace SchoolManagement.Domain.Interfaces
{
    public interface ICourseRepository : IBaseRepository<Course>
    {
        Task<Course?> GetCourseWithTeacherAsync(Guid courseId);

        Task<IEnumerable<Course>> GetAllWithTeacherIdAsync(Expression<Func<Course, bool>> filter = null);
    }
}

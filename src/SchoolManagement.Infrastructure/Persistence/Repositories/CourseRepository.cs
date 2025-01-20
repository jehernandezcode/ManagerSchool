using Microsoft.EntityFrameworkCore;
using SchoolManagement.Domain.Courses;
using SchoolManagement.Domain.Interfaces;
using SchoolManagement.Infrastructure.Persistence.Context;
using System.Linq.Expressions;

namespace SchoolManagement.Infrastructure.Persistence.Repositories
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {
        private readonly SchoolDbContext _context;
        public CourseRepository(SchoolDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Course>> GetAllWithTeacherIdAsync(Expression<Func<Course, bool>> filter = null)
        {
            var query = _context.Courses.AsQueryable();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            var coursesWithTeacher = await query
                .Include(c => c.Teacher)
                .ToListAsync();

            return coursesWithTeacher.Select(c =>
            {
                c.TeacherId = c.Teacher?.Id;
                return c;
            });
        }

        public async Task<Course?> GetCourseWithTeacherAsync(Guid courseId)
        {
            return await _context.Courses
                .Include(c => c.Teacher)
                .FirstOrDefaultAsync(c => c.Id == courseId);
        }
    }
}

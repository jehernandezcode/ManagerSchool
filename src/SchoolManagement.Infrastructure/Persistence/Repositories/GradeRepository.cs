using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Domain.Grades;
using SchoolManagement.Domain.Interfaces;
using SchoolManagement.Infrastructure.Persistence.Context;

namespace SchoolManagement.Infrastructure.Persistence.Repositories
{
    public class GradeRepository : BaseRepository<Grade>, IGradeRepository
    {
        private readonly SchoolDbContext _context;
        public GradeRepository(SchoolDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Grade>> GetAllWithRelationsAsync(Expression<Func<Grade, bool>> filter = null)
        {
            var query = _context.Grades.AsQueryable();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            var gradesWithRelations = await query
                .Include(g => g.Course)
                .Include(g => g.Student)
                .ToListAsync();

            return gradesWithRelations.Select(g =>
            {
                g.StudentId = g.Student?.Id ?? g.StudentId;
                g.CourseId = g.Course?.Id ?? g.CourseId;
                return g;
            });
        }

        public async Task<Grade?> GetGradeWithRelationsByIdAsync(Guid gradeId)
        {
            return await _context.Grades
            .Include(g => g.Course)
            .Include(g => g.Student)
                .FirstOrDefaultAsync(g => g.Id == gradeId);
        }
    }
}

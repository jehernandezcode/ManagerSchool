using Microsoft.EntityFrameworkCore;
using SchoolManagement.Domain.Grades;
using SchoolManagement.Domain.Interfaces;
using SchoolManagement.Domain.Students;
using SchoolManagement.Infrastructure.Persistence.Context;

namespace SchoolManagement.Infrastructure.Persistence.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        private readonly SchoolDbContext _context;
        public StudentRepository(SchoolDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Student?> GetStudentByIdentifiAsync(string identification)
        {
          return await _context.Students
        .FirstOrDefaultAsync(s => s.Identification == identification);
        }
    }
}

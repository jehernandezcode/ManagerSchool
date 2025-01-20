using SchoolManagement.Domain.Interfaces;
using SchoolManagement.Domain.Students;
using SchoolManagement.Infrastructure.Persistence.Context;

namespace SchoolManagement.Infrastructure.Persistence.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(SchoolDbContext context) : base(context)
        {
        }

    }
}

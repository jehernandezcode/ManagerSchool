using SchoolManagement.Domain.Interfaces;
using SchoolManagement.Domain.Teachers;
using SchoolManagement.Infrastructure.Persistence.Context;

namespace SchoolManagement.Infrastructure.Persistence.Repositories
{
    public class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(SchoolDbContext context) : base(context)
        {
        }
    }
}

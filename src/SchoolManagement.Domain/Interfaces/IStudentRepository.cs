using SchoolManagement.Domain.Students;

namespace SchoolManagement.Domain.Interfaces
{
    public interface IStudentRepository : IBaseRepository<Student>
    {
        Task<Student?> GetStudentByIdentifiAsync(string identification);
    }
}

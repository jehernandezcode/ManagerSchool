
using SchoolManagement.Application.Student.Dtos;

namespace SchoolManagement.Application.Student.Interfaces
{
    public interface IServiceStudent
    {
        Task Add(CreateStudentDto student);
        Task<StudentDto?> GetByIdAsync(Guid id);
        Task<IEnumerable<StudentDto>> GetStudentsAsync(FilterStudentDto filters);
        Task UpdateStudent(Guid id, UpdateStudentDto updateStudentDto);
        Task DeleteStudent(Guid id);
    }
}

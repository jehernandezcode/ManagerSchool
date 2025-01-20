
using SchoolManagement.Application.Student.Dtos;

namespace SchoolManagement.Application.Student.Interfaces
{
    public interface IServiceStudent
    {
        Task Add(CreateStudentDto student);
        Task<StudentDto?> GetByIdAsync(string id);
        Task<IEnumerable<StudentDto>> GetStudentsAsync(FilterStudentDto filters);
        Task UpdateStudent(string id, UpdateStudentDto updateStudentDto);
        Task DeleteStudent(string id);
    }
}

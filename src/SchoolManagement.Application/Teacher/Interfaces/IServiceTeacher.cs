using SchoolManagement.Application.Teacher.Dtos;

namespace SchoolManagement.Application.Teacher.Interfaces
{
    public interface IServiceTeacher
    {
        Task Add(CreateTeacherDto teacher);
        Task<TeacherDto?> GetByIdAsync(Guid id);
        Task<IEnumerable<TeacherDto>> GetTeachersAsync(FilterTeacherDto filters);
        Task UpdateTeacher(Guid id, UpdateTeacherDto updateTeacherDto);
        Task DeleteTeacher(Guid id);
    }
}

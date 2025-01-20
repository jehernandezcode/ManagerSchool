
using SchoolManagement.Application.Teacher.Dtos;

namespace SchoolManagement.Application.Course.Interfaces
{
    public interface IServiceCourse
    {
        Task Add(CreateCourseDto course);
        Task<CourseDto?> GetByIdAsync(Guid id);
        Task<IEnumerable<CourseDto>> GetCoursesAsync(FilterCourseDto filters);
        Task UpdateCourse(Guid id, UpdateCourseDto updateCourseDto);
        Task DeleteCourse(Guid id);
    }
}


using SchoolManagement.Application.Grade.Dtos;

namespace SchoolManagement.Application.Grade.Interfaces
{
    public interface IServiceGrade
    {
        Task Add(CreateGradeDto grade);
        Task<GradeDto?> GetByIdAsync(Guid id);
        Task<IEnumerable<GradeDto>> GetGradesAsync(FilterGradeDto filters);
        Task UpdateGrade(Guid id, UpdateGradeDto updateGradeDto);
        Task DeleteGrade(Guid id);
    }
}

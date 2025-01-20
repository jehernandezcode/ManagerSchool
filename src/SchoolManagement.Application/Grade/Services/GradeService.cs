using System.Linq.Expressions;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using SchoolManagement.Application.Exceptions;
using SchoolManagement.Application.Grade.Dtos;
using SchoolManagement.Application.Grade.Interfaces;
using SchoolManagement.Domain.Interfaces;

namespace SchoolManagement.Application.Grade.Services
{
    public class GradeService : IServiceGrade
    {

        private readonly IGradeRepository _gradeRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;
        public GradeService(IGradeRepository gradeRepository,
            IStudentRepository studentRepository,
            ICourseRepository courseRepository,
            IMapper mapper)
        {
            _gradeRepository = gradeRepository;
            _studentRepository = studentRepository;
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public async Task Add(CreateGradeDto grade)
        {

            var course = await _courseRepository.GetByIdAsync(grade.CourseId);
            var student = await _studentRepository.GetByIdAsync(grade.StudentId);

            if(course == null && student == null)
            {
                throw new NotFoundException("Course or student not found");
            }

            var newGrade = new Domain.Grades.Grade(grade.StudentId,grade.CourseId, grade.Value );

            await _gradeRepository.AddAsync(newGrade);
        }

        public async Task DeleteGrade(Guid id)
        {
            var grade = await _gradeRepository.GetByIdAsync(id);

            if(grade == null)
            {
                throw new NotFoundException("grade not found");
            }
            await _gradeRepository.DeleteAsync(grade);
        }

        public async Task<GradeDto?> GetByIdAsync(Guid id)
        {
            var grade = await _gradeRepository.GetGradeWithRelationsByIdAsync(id);

            if (grade == null)
            {
                throw new NotFoundException("grade not found");
            }

            return _mapper.Map<GradeDto>(grade);
        }

        public async Task<IEnumerable<GradeDto>> GetGradesAsync(FilterGradeDto filters)
        {
            Expression<Func<Domain.Grades.Grade, bool>>? filter = null;

            var grades = await _gradeRepository.GetAllWithRelationsAsync(filter);

            return _mapper.Map<IEnumerable<GradeDto>>(grades);
        }

        public async Task UpdateGrade(Guid id, UpdateGradeDto updateGradeDto)
        {
            var patchDocument = new JsonPatchDocument<Domain.Grades.Grade>();

            if (updateGradeDto.StudentId.HasValue)
            {
                patchDocument.Replace(data => data.StudentId, updateGradeDto.StudentId);
            }

            if (updateGradeDto.CourseId.HasValue)
            {
                patchDocument.Replace(data => data.CourseId, updateGradeDto.CourseId);
            }

            if (updateGradeDto.Value != null)
            {
                patchDocument.Replace(data => data.GradeValue.Value, updateGradeDto.Value);
            }

            var grade = await _gradeRepository.GetByIdAsync(id) ?? throw new NotFoundException("grade not found");

            patchDocument.ApplyTo(grade);

            await _gradeRepository.UpdateAsync(grade);
        }
    }
}

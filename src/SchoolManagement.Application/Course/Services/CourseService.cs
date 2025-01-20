

using System.Linq.Expressions;
using AutoMapper;
using SchoolManagement.Application.Course.Interfaces;
using SchoolManagement.Application.Exceptions;
using SchoolManagement.Application.Teacher.Dtos;
using SchoolManagement.Domain.Interfaces;

namespace SchoolManagement.Application.Course.Services
{
    public class CourseService : IServiceCourse
    {
        private readonly ICourseRepository _courseRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository courseRepository, ITeacherRepository teacherRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _teacherRepository = teacherRepository;
            _mapper = mapper;
        }

        public async Task Add(CreateCourseDto course)
        {
            var newCourse = new Domain.Courses.Course
            {
               Id = Guid.NewGuid(),
               Title = course.Title,
            };

            await _courseRepository.AddAsync(newCourse);
        }

        public async Task DeleteCourse(Guid id)
        {
            var course = await _courseRepository.GetByIdAsync(id);

            if(course == null)
            {
                throw new NotFoundException("Course not found");
            }
            
            await _courseRepository.DeleteAsync(course);
        }

        public async Task<CourseDto?> GetByIdAsync(Guid id)
        {
            var course = await _courseRepository.GetCourseWithTeacherAsync(id);

            if (course == null)
            {
                throw new NotFoundException("Course not found");
            }

            return _mapper.Map<CourseDto>(course);
        }

        public async Task<IEnumerable<CourseDto>> GetCoursesAsync(FilterCourseDto filters)
        {

            Expression<Func<Domain.Courses.Course, bool>>? filter = null;

            if (filters != null)
            {
                filter = course =>
                (string.IsNullOrEmpty(filters.Title) || course.Title.ToLower() == filters.Title.ToLower()) &&
                (!filters.TeacherId.HasValue || course.TeacherId == filters.TeacherId);
            }

            var courses = await _courseRepository.GetAllWithTeacherIdAsync(filter);

            return _mapper.Map<IEnumerable<CourseDto>>(courses);
        }

        public async Task UpdateCourse(Guid id, UpdateCourseDto updateCourseDto)
        {
            var course = await _courseRepository.GetByIdAsync(id);
            if (course == null)
            {
                throw new NotFoundException("Course not found");
            }

            course.Title = updateCourseDto.Title;

            if (updateCourseDto.TeacherId.HasValue)
            {
                var teacher = await _teacherRepository.GetByIdAsync(updateCourseDto.TeacherId.Value);
                if (teacher == null)
                {
                    throw new NotFoundException("Teacher not found");
                }
                course.Teacher = teacher;
            }

            await _courseRepository.UpdateAsync(course);
        }
    }
}

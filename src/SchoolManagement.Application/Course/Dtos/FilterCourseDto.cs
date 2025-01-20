
using FluentValidation;
using SchoolManagement.Application.Course.Validator;

namespace SchoolManagement.Application.Teacher.Dtos
{
    public class FilterCourseDto
    {
        public string? Title { get; set; }
        public Guid? TeacherId { get; set; }
    }

    public class FilterCourseDtoValidator : AbstractValidator<FilterCourseDto>
    {
        public FilterCourseDtoValidator()
        {
            RuleFor(x => x.Title)
                .MaximumLength(50).WithMessage("Title cannot exceed 50 characters.");
            RuleFor(x => x.TeacherId).TeacherIdRules();
        }
    }
}

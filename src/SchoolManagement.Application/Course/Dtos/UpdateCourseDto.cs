
using FluentValidation;
using SchoolManagement.Application.Course.Validator;

namespace SchoolManagement.Application.Teacher.Dtos
{
    public class UpdateCourseDto
    {
        public string? Title { get; set; }
        public Guid? TeacherId { get; set; }
    }

    public class UpdateCourseDtoValidator : AbstractValidator<UpdateCourseDto>
    {
        public UpdateCourseDtoValidator()
        {
            RuleFor(x => x.Title).TitleRules();
            RuleFor(x => x.TeacherId).TeacherIdRules();
        }
    }
}

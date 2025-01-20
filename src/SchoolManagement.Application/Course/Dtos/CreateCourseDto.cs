using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using FluentValidation;
using SchoolManagement.Application.Course.Validator;

namespace SchoolManagement.Application.Teacher.Dtos
{
    public class CreateCourseDto
    {
        [Required]
        [DefaultValue("Matematicas")]
        public string Title { get; set; }
        public Guid? TeacherId { get; set; }
    }

    public class CreateCourseDtoValidator : AbstractValidator<CreateCourseDto>
    {
        public CreateCourseDtoValidator()
        {
            RuleFor(x => x.Title).TitleRules();
            RuleFor(x => x.TeacherId).TeacherIdRules();
        }
    }
}

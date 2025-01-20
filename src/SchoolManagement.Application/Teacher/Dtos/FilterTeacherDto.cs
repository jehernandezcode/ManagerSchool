
using FluentValidation;

namespace SchoolManagement.Application.Teacher.Dtos
{
    public class FilterTeacherDto
    {
        public string? FirstName { get; set; }
        public string? lastName { get; set; }

    }

    public class FilterTeacherDtoValidator : AbstractValidator<FilterTeacherDto>
    {
        public FilterTeacherDtoValidator()
        {
            RuleFor(x => x.FirstName)
                 .MaximumLength(50);

            RuleFor(x => x.lastName)
                .MaximumLength(50);
        }
    }
}

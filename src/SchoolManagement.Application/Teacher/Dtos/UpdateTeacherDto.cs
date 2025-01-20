
using FluentValidation;

namespace SchoolManagement.Application.Teacher.Dtos
{
    public class UpdateTeacherDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }

    public class UpdateTeacherDtoValidator : AbstractValidator<UpdateTeacherDto>
    {
        public UpdateTeacherDtoValidator()
        {
            RuleFor(x => x.FirstName)
                 .MaximumLength(50);

            RuleFor(x => x.LastName)
                .MaximumLength(50);
        }
    }
}

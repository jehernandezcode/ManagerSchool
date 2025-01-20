
using FluentValidation;

namespace SchoolManagement.Application.Student.Dtos
{
    public class UpdateStudentDto
    {
        public string? Identification { get; set; } = String.Empty;
        public string? FirsName { get; set; } = default!;
        public string? LastName { get; set; } = default!;
    }

    public class UpdateStudentDtoValidator : AbstractValidator<UpdateStudentDto>
    {
        public UpdateStudentDtoValidator()
        {
            RuleFor(x => x.FirsName)
                 .MaximumLength(20);

            RuleFor(x => x.FirsName)
                 .MaximumLength(50);

            RuleFor(x => x.LastName)
                .MaximumLength(50);
        }
    }
}

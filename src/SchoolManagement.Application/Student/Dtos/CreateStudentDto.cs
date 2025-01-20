
using FluentValidation;

namespace SchoolManagement.Application.Student.Dtos
{
    public class CreateStudentDto
    {
        public string Identification { get; set; } = String.Empty;
        public string FirsName { get; set; } = default!;
        public string LastName { get; set; } = default!;
    }

    public class CreateStudentDtoValidator : AbstractValidator<CreateStudentDto>
    {
        public CreateStudentDtoValidator()
        {
            RuleFor(x => x.Identification)
                 .NotEmpty().WithMessage("Identification is required.")
                 .MaximumLength(20);

            RuleFor(x => x.FirsName)
                 .NotEmpty().WithMessage("FirsName is required.")
                 .MaximumLength(50);

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("LastName is required.")
                .MaximumLength(50);
        }
    }
}

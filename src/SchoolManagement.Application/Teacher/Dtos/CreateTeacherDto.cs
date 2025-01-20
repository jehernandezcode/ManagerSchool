using FluentValidation;

namespace SchoolManagement.Application.Teacher.Dtos
{
    public class CreateTeacherDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class CreateTeacherDtoValidator : AbstractValidator<CreateTeacherDto>
    {
        public CreateTeacherDtoValidator()
        {
            RuleFor(x => x.FirstName)
                 .NotEmpty().WithMessage("FirsName is required.")
                 .MaximumLength(50);

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("LastName is required.")
                .MaximumLength(50);
        }
    }


}

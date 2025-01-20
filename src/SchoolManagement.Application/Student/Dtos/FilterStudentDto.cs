
using FluentValidation;

namespace SchoolManagement.Application.Student.Dtos
{
    public class FilterStudentDto
    {
        public string? Identification { get; set; } = String.Empty;
        public string? FirsName { get; set; } = default!;
        public string? LastName { get; set; } = default!;
    }

    public class FilterStudentDtoValidator : AbstractValidator<FilterStudentDto>
    {
        public FilterStudentDtoValidator()
        {
            RuleFor(x => x.Identification)
                 .MaximumLength(50);

            RuleFor(x => x.FirsName)
                 .MaximumLength(50);

            RuleFor(x => x.LastName)
                .MaximumLength(50);
        }
    }
}

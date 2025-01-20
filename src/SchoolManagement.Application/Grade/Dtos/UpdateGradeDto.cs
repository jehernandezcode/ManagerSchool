
using FluentValidation;

namespace SchoolManagement.Application.Grade.Dtos
{
    public class UpdateGradeDto
    {
        public Guid? StudentId { get; set; }
        public Guid? CourseId { get; set; }
        public decimal? Value { get; set; }
    }

    public class UpdateGradeDtoValidator : AbstractValidator<UpdateGradeDto>
    {
        public UpdateGradeDtoValidator()
        {
            RuleFor(x => x.StudentId)
                 .Must(id => id != Guid.Empty).WithMessage("StudentId cannot be an empty GUID.");

            RuleFor(x => x.CourseId)
                .Must(id => id != Guid.Empty).WithMessage("CourseId cannot be an empty GUID.");

            RuleFor(x => x.Value)
                .InclusiveBetween(0.00m, 99.99m).WithMessage("Value must be between 0.00 and 99.99.")
                .ScalePrecision(2, 3).WithMessage("Value must have a maximum of 3 digits, with up to 2 decimal places.");
        }
    }
}

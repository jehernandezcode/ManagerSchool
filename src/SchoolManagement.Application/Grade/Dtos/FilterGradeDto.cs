
using FluentValidation;
using SchoolManagement.Application.Teacher.Dtos;

namespace SchoolManagement.Application.Grade.Dtos
{
    public class FilterGradeDto
    {
        public Guid? StudentId { get; set; }
        public Guid? CourseId { get; set; }
        public decimal? MinValue { get; set; }
        public decimal? MaxValue { get; set; }
    }

    public class FilterGradeDtoValidator : AbstractValidator<FilterGradeDto>
    {
        public FilterGradeDtoValidator()
        {
            RuleFor(x => x.StudentId)
                 .Must(id => id != Guid.Empty).WithMessage("StudentId cannot be an empty GUID.");

            RuleFor(x => x.CourseId)
                .Must(id => id != Guid.Empty).WithMessage("CourseId cannot be an empty GUID.");

            RuleFor(x => x.MinValue)
                .InclusiveBetween(0.00m, 99.99m).WithMessage("Value must be between 0.00 and 99.99.")
                .ScalePrecision(2, 3).WithMessage("MinValue must have a maximum of 3 digits, with up to 2 decimal places.");

            RuleFor(x => x.MaxValue)
                .InclusiveBetween(0.00m, 99.99m).WithMessage("Value must be between 0.00 and 99.99.")
                .ScalePrecision(2, 3).WithMessage("MaxValue must have a maximum of 3 digits, with up to 2 decimal places.");
        }
    }
}


using FluentValidation;

namespace SchoolManagement.Application.Course.Validator
{
    public static class CommonValidatorCourse
    {
        public static IRuleBuilderOptions<T, string?> TitleRules<T>(this IRuleBuilder<T, string?> ruleBuilder)
        {
            return ruleBuilder
                .NotEmpty().WithMessage("Title is required.")
                .MaximumLength(50).WithMessage("Title cannot exceed 50 characters.");
        }

        public static IRuleBuilderOptions<T, Guid?> TeacherIdRules<T>(this IRuleBuilder<T, Guid?> ruleBuilder)
        {
            return ruleBuilder
                .Must(id => id != Guid.Empty).WithMessage("TeacherId cannot be an empty GUID.");
        }
    }
}

using SchoolManagement.Domain.Common;

namespace SchoolManagement.Domain.Grades
{
    public class GradeValue
    {
        public decimal Value { get; set; }

        public GradeValue(decimal value)
        {
            if (value < 0 || value > 5.0m)
            {
                throw new DomainException("El valor de la calificación debe estar entre 0 y 5.0.");
            }

            Value = value;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not GradeValue other) return false;
            return Value == other.Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return Value.ToString("F1");
        }
    }
}

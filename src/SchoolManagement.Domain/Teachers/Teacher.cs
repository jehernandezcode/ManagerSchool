

using SchoolManagement.Domain.Common;

namespace SchoolManagement.Domain.Teachers
{
    public class Teacher : AuditableEntity
    {
        public int Identification { get; set; }
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;

    }
}

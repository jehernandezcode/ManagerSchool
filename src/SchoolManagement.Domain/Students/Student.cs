using SchoolManagement.Domain.Common;

namespace SchoolManagement.Domain.Students
{
    public class Student : AuditableEntity
    {
        public string Identification { get; set; } = String.Empty;
        public string FirsName { get; set; } = default!;
        public string LastName { get; set; } = default!;
    }
}

using SchoolManagement.Domain.Common;

namespace SchoolManagement.Domain.Students
{
    public class Student : AuditableEntity
    {
        public int Identification { get; set; }
        public string FirsName { get; set; } = default!;
        public string LastName { get; set; } = default!;
    }
}

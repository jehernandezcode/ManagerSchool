using SchoolManagement.Domain.Common;
using SchoolManagement.Domain.Teachers;

namespace SchoolManagement.Domain.Courses
{
    public class Course : AuditableEntity
    {
        public string Title { get; set; } = default!;
        public Guid? TeacherId { get; set; }
        public Teacher? Teacher { get; set; } = default!;
    }
}

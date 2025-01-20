using SchoolManagement.Domain.Common;
using SchoolManagement.Domain.Courses;
using SchoolManagement.Domain.Students;

namespace SchoolManagement.Domain.Grades
{
    public class Grade : AuditableEntity
    {
        public Guid StudentId { get; set; }
        public int Identification { get; set; }
        public Student Student { get; set; } = default!;
        public Guid CourseId { get; set; }
        public Course Course { get; set; } = default!;
        public GradeValue GradeValue { get; set; }

        public Grade(Guid studentId, Guid courseId, decimal gradeValue)
        {
            Id = Guid.NewGuid();
            StudentId = studentId;
            CourseId = courseId;
            GradeValue = new GradeValue(gradeValue);
        }

        public void UpdateGrade(decimal newValue)
        {
            GradeValue = new GradeValue(newValue);
        }
        public Grade()
        {

        }
    }
}

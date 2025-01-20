namespace SchoolManagement.Application.Grade.Dtos
{
    public class GradeDto
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Domain.Students.Student Student { get; set; } = default!;
        public Guid CourseId { get; set; }
        public Domain.Courses.Course Course { get; set; } = default!;
        public decimal Value { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeleteAt { get; set; }
    }
}

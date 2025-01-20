namespace SchoolManagement.Application.Teacher.Dtos
{
    public class CourseDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public Guid? TeacherId { get; set; }
        public Domain.Teachers.Teacher? Teacher { get; set; } = default!;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeleteAt { get; set; }
    }
}

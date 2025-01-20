
namespace SchoolManagement.Application.Student.Dtos
{
    public class StudentDto
    {
        public Guid Id { get; set; }
        public string Identification { get; set; } = String.Empty;
        public string FirsName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeleteAt { get; set; }
    }
}

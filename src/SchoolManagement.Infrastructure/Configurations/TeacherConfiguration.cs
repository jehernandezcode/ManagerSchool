using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Domain.Teachers;
using SchoolManagement.Domain.Students;

namespace SchoolManagement.Infrastructure.Configurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.FirstName)
               .IsRequired()
               .HasMaxLength(50);

            builder.Property(s => s.LastName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasData(
                new Teacher
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Lara",
                    LastName = "Bonilla",
                    CreatedAt = DateTime.UtcNow,
                },
                new Teacher
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Julian",
                    LastName = "Caro",
                    CreatedAt = DateTime.UtcNow,
                }
            );
        }
    }
}

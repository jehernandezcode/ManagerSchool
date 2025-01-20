using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Domain.Courses;
using SchoolManagement.Domain.Students;

namespace SchoolManagement.Infrastructure.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Title)
               .IsRequired()
               .HasMaxLength(50);

            builder.HasOne(c => c.Teacher)
            .WithMany()
            .HasForeignKey(c => c.TeacherId)
            .IsRequired(false);

            builder.Property(c => c.TeacherId)
                .IsRequired(false);


            builder.HasData(
             new Course
             {
                 Id = Guid.NewGuid(),
                 Title = "matematicas",
                 CreatedAt = DateTime.UtcNow,
             },
             new Course
             {
                 Id = Guid.NewGuid(),
                 Title= "Informatica",
                 CreatedAt = DateTime.UtcNow,
             }
 );

        }


    }
}

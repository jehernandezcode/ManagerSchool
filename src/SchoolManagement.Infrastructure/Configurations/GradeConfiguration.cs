

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolManagement.Domain.Grades;

namespace SchoolManagement.Infrastructure.Configurations
{
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.HasKey(s => s.Id);

            builder.OwnsOne(g => g.GradeValue, gradeValue =>
            {
                gradeValue.Property(g => g.Value)
                    .HasColumnName("Value")
                    .HasColumnType("decimal(3,2)")
                    .IsRequired();
            });

            builder.HasOne(s => s.Student)
            .WithMany()
            .HasForeignKey(s => s.StudentId)
            .IsRequired();

            builder.HasOne(s => s.Course)
                .WithMany()
                .HasForeignKey(s => s.CourseId)
                .IsRequired();
        }
    }
}

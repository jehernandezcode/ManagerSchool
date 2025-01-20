using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Domain.Students;

namespace SchoolManagement.Infrastructure.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Identification)
                .IsRequired().HasMaxLength(20);
          
            builder.HasIndex(s => s.Identification)
                .IsUnique();

            builder.Property(s => s.FirsName)
               .IsRequired()
               .HasMaxLength(50);

            builder.Property(s => s.LastName)
                   .IsRequired()
                   .HasMaxLength(50);
        }
    }
}

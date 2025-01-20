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


            builder.HasData(
                new Student { Id = Guid.NewGuid(), Identification = "100000001", FirsName = "Juan", LastName = "Lazo", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000002", FirsName = "Laura", LastName = "Villa", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000003", FirsName = "Carlos", LastName = "Ruiz", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000004", FirsName = "Ana", LastName = "García", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000005", FirsName = "Pedro", LastName = "Martínez", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000006", FirsName = "María", LastName = "Fernández", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000007", FirsName = "Jorge", LastName = "López", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000008", FirsName = "Luisa", LastName = "Hernández", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000009", FirsName = "Andrés", LastName = "Pérez", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000010", FirsName = "Camila", LastName = "Ortiz", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000011", FirsName = "Mateo", LastName = "Ramírez", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000012", FirsName = "Sofía", LastName = "Ríos", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000013", FirsName = "David", LastName = "Morales", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000014", FirsName = "Valentina", LastName = "Gómez", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000015", FirsName = "Sebastián", LastName = "Castro", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000016", FirsName = "Isabella", LastName = "Rojas", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000017", FirsName = "Daniel", LastName = "Mendoza", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000018", FirsName = "Fernanda", LastName = "Reyes", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000019", FirsName = "Samuel", LastName = "Cruz", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000020", FirsName = "Mía", LastName = "Peña", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000021", FirsName = "Gabriel", LastName = "Pacheco", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000022", FirsName = "Antonia", LastName = "Vargas", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000023", FirsName = "Elías", LastName = "Flores", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000024", FirsName = "Martina", LastName = "Carvajal", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000025", FirsName = "Luciano", LastName = "Navarro", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000026", FirsName = "Emma", LastName = "Vera", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000027", FirsName = "Tomás", LastName = "Silva", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000028", FirsName = "Abril", LastName = "Salinas", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000029", FirsName = "Nicolás", LastName = "Acosta", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000030", FirsName = "Renata", LastName = "Arce", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000031", FirsName = "Agustín", LastName = "Linares", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000032", FirsName = "Bianca", LastName = "Quintana", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000033", FirsName = "Maximiliano", LastName = "Barrios", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000034", FirsName = "Julia", LastName = "Fuentes", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000035", FirsName = "Felipe", LastName = "Carrillo", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000036", FirsName = "Regina", LastName = "Medina", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000037", FirsName = "Simón", LastName = "Escobar", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000038", FirsName = "Paulina", LastName = "Campos", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000039", FirsName = "Iván", LastName = "Villalobos", CreatedAt = DateTime.UtcNow },
                new Student { Id = Guid.NewGuid(), Identification = "100000040", FirsName = "Alejandra", LastName = "Delgado", CreatedAt = DateTime.UtcNow }
);
        }
    }
}

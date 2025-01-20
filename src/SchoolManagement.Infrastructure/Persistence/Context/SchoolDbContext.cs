using Microsoft.EntityFrameworkCore;
using SchoolManagement.Domain.Common;
using SchoolManagement.Domain.Courses;
using SchoolManagement.Domain.Grades;
using SchoolManagement.Domain.Students;
using SchoolManagement.Domain.Teachers;
using System.Linq.Expressions;

namespace SchoolManagement.Infrastructure.Persistence.Context
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        public SchoolDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //controladores customizados para no mapear Teacher del dominio, por medio de entidades de configuracion personalizadas
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SchoolDbContext).Assembly);

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                var entityType = entity.ClrType;
                if (typeof(AuditableEntity).IsAssignableFrom(entityType))
                {
                    var parameter = Expression.Parameter(entityType, "e");
                    var property = Expression.Property(parameter, "DeleteAt");
                    var isNotDeleted = Expression.Equal(property, Expression.Constant(null, typeof(DateTime?)));

                    var lambda = Expression.Lambda(isNotDeleted, parameter);

                    entity.SetQueryFilter(lambda);
                }
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .LogTo(Console.WriteLine)
                     .EnableDetailedErrors()
                .EnableSensitiveDataLogging();

        }

        public override int SaveChanges()
        {
            SetAuditableEntities();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetAuditableEntities();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void SetAuditableEntities()
        {
            var entities = ChangeTracker.Entries()
                .Where(e => e.Entity is AuditableEntity && (e.State == EntityState.Added || e.State == EntityState.Modified || e.State == EntityState.Deleted));

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((AuditableEntity)entity.Entity).CreatedAt = DateTime.UtcNow;
                }

                if (entity.State == EntityState.Modified)
                {
                    ((AuditableEntity)entity.Entity).UpdatedAt = DateTime.UtcNow;
                }

                if (entity.State == EntityState.Deleted)
                {
                    ((AuditableEntity)entity.Entity).DeleteAt = DateTime.UtcNow;
                    entity.State = EntityState.Modified;
                }
            }

        }
    }
}

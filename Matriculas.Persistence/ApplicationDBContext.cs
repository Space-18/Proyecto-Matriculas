using Matriculas.Domain.Entities;
using Matriculas.Persistence.Helper;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Matriculas.Persistence
{
    public class ApplicationDBContext(DbContextOptions options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            AuditHelper.ApplyAuditInformation(this);
            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Aula> Aulas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Seccion> Seccions { get; set; }
    }
}

using Matriculas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Matriculas.Persistence.Configurations
{
    internal class AlumnoConfiguration : IEntityTypeConfiguration<Alumno>
    {
        public void Configure(EntityTypeBuilder<Alumno> builder)
        {
            builder.HasData(new Alumno()
            {
                IdAlumno = 1,
                Nombre = "Alumno 1",
                IsActive = true,
                CreateDate = DateTime.Now,
            },
            new Alumno()
            {
                IdAlumno = 2,
                Nombre = "Alumno 2",
                IsActive = true,
                CreateDate = DateTime.Now,
            },
            new Alumno()
            {
                IdAlumno = 3,
                Nombre = "Alumno 3",
                IsActive = true,
                CreateDate = DateTime.Now,
            },
            new Alumno()
            {
                IdAlumno = 4,
                Nombre = "Alumno 4",
                IsActive = true,
                CreateDate = DateTime.Now,
            },
            new Alumno()
            {
                IdAlumno = 5,
                Nombre = "Alumno 5",
                IsActive = true,
                CreateDate = DateTime.Now,
            });
        }
    }
}

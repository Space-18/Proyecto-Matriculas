using Matriculas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Matriculas.Persistence.Configurations
{
    internal class CursoConfiguration : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.HasData(new Curso()
            {
                IdCurso = 1,
                DesCurso = "Curso de prueba 1",
                IdSeccion = 1,
                IsActive = true,
                CreateDate = DateTime.Now
            },
            new Curso()
            {
                IdCurso = 2,
                DesCurso = "Curso de prueba 2",
                IdSeccion = 1,
                IsActive = true,
                CreateDate = DateTime.Now
            },
            new Curso()
            {
                IdCurso = 3,
                DesCurso = "Curso de prueba 3",
                IdSeccion = 2,
                IsActive = true,
                CreateDate = DateTime.Now
            },
            new Curso()
            {
                IdCurso = 4,
                DesCurso = "Curso de prueba 4",
                IdSeccion = 2,
                IsActive = true,
                CreateDate = DateTime.Now
            },
            new Curso()
            {
                IdCurso = 5,
                DesCurso = "Curso de prueba 5",
                IdSeccion = 3,
                IsActive = true,
                CreateDate = DateTime.Now
            },
            new Curso()
            {
                IdCurso = 6,
                DesCurso = "Curso de prueba 6",
                IdSeccion = 3,
                IsActive = true,
                CreateDate = DateTime.Now
            });
        }
    }
}

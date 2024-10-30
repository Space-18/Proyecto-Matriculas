using Matriculas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Matriculas.Persistence.Configurations
{
    internal class SeccionConfiguration : IEntityTypeConfiguration<Seccion>
    {
        public void Configure(EntityTypeBuilder<Seccion> builder)
        {
            builder.HasData(new Seccion()
            {
                IdSeccion = 1,
                IdAula = 1,
                Turno = "Mañana",
                HoraInicio = new TimeOnly(8, 00, 00),
                HoraFin = new TimeOnly(10, 00, 00),
                IsActive = true,
                CreateDate = DateTime.Now,
            },
            new Seccion()
            {
                IdSeccion = 2,
                IdAula = 1,
                Turno = "Tarde",
                HoraInicio = new TimeOnly(14, 00, 00),
                HoraFin = new TimeOnly(16, 00, 00),
                IsActive = true,
                CreateDate = DateTime.Now,
            },
            new Seccion()
            {
                IdSeccion = 3,
                IdAula = 2,
                Turno = "Noche",
                HoraInicio = new TimeOnly(20, 00, 00),
                HoraFin = new TimeOnly(22, 00, 00),
                IsActive = true,
                CreateDate = DateTime.Now,
            });
        }
    }
}

using Matriculas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Matriculas.Persistence.Configurations
{
    internal class AulaConfiguration : IEntityTypeConfiguration<Aula>
    {
        public void Configure(EntityTypeBuilder<Aula> builder)
        {
            builder.HasData(new Aula()
            {
                IdAula = 1,
                Capacidad = 2,
                IsActive = true,
                CreateDate = DateTime.Now,
            },
            new Aula()
            {
                IdAula = 2,
                Capacidad = 2,
                IsActive = true,
                CreateDate = DateTime.Now,
            });
        }
    }
}

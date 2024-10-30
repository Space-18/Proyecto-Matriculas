using Matriculas.Application.Contracts.Persistence;
using Matriculas.Domain.Entities;
using Matriculas.Persistence.Repositories.Commons;

namespace Matriculas.Persistence.Repositories
{
    internal class AulaRepository : BaseRepository<Aula>, IAulaRepository
    {
        public AulaRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}

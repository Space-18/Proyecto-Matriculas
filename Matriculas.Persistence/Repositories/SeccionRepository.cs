using Matriculas.Application.Contracts.Persistence;
using Matriculas.Domain.Entities;
using Matriculas.Persistence.Repositories.Commons;

namespace Matriculas.Persistence.Repositories
{
    internal class SeccionRepository : BaseRepository<Seccion>, ISeccionRepository
    {
        public SeccionRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}

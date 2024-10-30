using Matriculas.Application.Contracts.Persistence;
using Matriculas.Domain.Entities;
using Matriculas.Persistence.Repositories.Commons;

namespace Matriculas.Persistence.Repositories
{
    internal class MatriculaRepository : BaseRepository<Matricula>, IMatriculaRepository
    {
        public MatriculaRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}

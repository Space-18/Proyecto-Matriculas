using Matriculas.Application.Contracts.Persistence.Commons;
using Matriculas.Domain.Entities;

namespace Matriculas.Application.Contracts.Persistence
{
    public interface ICursoRepository : IBaseRepository<Curso>
    {
        Task<Curso?> GetCursoWithDetails(long cursoId);
    }
}

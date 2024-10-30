using Matriculas.Application.Contracts.Persistence;
using Matriculas.Domain.Entities;
using Matriculas.Persistence.Repositories.Commons;
using Microsoft.EntityFrameworkCore;

namespace Matriculas.Persistence.Repositories
{
    internal class CursoRepository : BaseRepository<Curso>, ICursoRepository
    {
        public CursoRepository(ApplicationDBContext context) : base(context)
        {
        }

        public async Task<Curso?> GetCursoWithDetails(long cursoId)
        {
            return await _context.Cursos.Include(i=> i.Seccion).ThenInclude(ti=> ti.Aula).FirstOrDefaultAsync(x => x.IdCurso == cursoId);
        }
    }
}

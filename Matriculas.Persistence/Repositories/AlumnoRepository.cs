using Matriculas.Application.Contracts.Persistence;
using Matriculas.Domain.Entities;
using Matriculas.Persistence.Repositories.Commons;

namespace Matriculas.Persistence.Repositories
{
    internal class AlumnoRepository : BaseRepository<Alumno>, IAlumnoRepository
    {
        public AlumnoRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}

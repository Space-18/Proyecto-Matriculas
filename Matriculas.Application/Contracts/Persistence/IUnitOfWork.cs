using Matriculas.Application.Contracts.Persistence.Commons;
using Matriculas.Domain.Entities.Commons;

namespace Matriculas.Application.Contracts.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        IAlumnoRepository AlumnoRepository { get; }
        IAulaRepository AulaRepository { get; }
        ICursoRepository CursoRepository { get; }
        IMatriculaRepository MatriculaRepository { get; }
        ISeccionRepository SeccionRepository { get; }

        IBaseRepository<TEntity> Repository<TEntity>() where TEntity : BaseModel;
        Task<int> Complete();
    }
}

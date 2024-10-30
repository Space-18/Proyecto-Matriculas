using Matriculas.Application.Contracts.Persistence;
using Matriculas.Application.Contracts.Persistence.Commons;
using Matriculas.Domain.Entities.Commons;
using Matriculas.Persistence.Repositories.Commons;
using System.Collections;

namespace Matriculas.Persistence.Repositories
{
    internal class UnitOfWork : IUnitOfWork
    {
        private Hashtable? _repositories;
        private readonly ApplicationDBContext _context;
        private IAlumnoRepository? _alumnoRepository;
        private IAulaRepository? _aulaRepository;
        private ICursoRepository? _cursoRepository;
        private IMatriculaRepository? _matriculaRepository;
        private ISeccionRepository? _seccionRepository;

        private bool disposedValue;

        public IAlumnoRepository AlumnoRepository => _alumnoRepository ??= new AlumnoRepository(_context);

        public IAulaRepository AulaRepository => _aulaRepository ??= new AulaRepository(_context);

        public ICursoRepository CursoRepository => _cursoRepository ??= new CursoRepository(_context);

        public IMatriculaRepository MatriculaRepository => _matriculaRepository ??= new MatriculaRepository(_context);

        public ISeccionRepository SeccionRepository => _seccionRepository ??= new SeccionRepository(_context);

        public UnitOfWork(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public IBaseRepository<TEntity> Repository<TEntity>() where TEntity : BaseModel
        {
            _repositories ??= new();

            var type = typeof(TEntity).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(BaseRepository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _context);
                _repositories.Add(type, repositoryInstance);
            }

            return (IBaseRepository<TEntity>)_repositories[type]!;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _repositories?.Clear();
                }
                else
                {
                    _context.Dispose();
                }

                disposedValue = true;
            }
        }

        ~UnitOfWork()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}

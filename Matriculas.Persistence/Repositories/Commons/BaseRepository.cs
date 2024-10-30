using Matriculas.Application.Contracts.Persistence.Commons;
using Matriculas.Domain.Entities.Commons;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Matriculas.Persistence.Repositories.Commons
{
    internal class BaseRepository<T>(ApplicationDBContext context) : IBaseRepository<T> where T : BaseModel
    {
        public readonly ApplicationDBContext _context = context;

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetOneByAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public IQueryable<T> GetOneBy(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            entity.IsActive = false;
            Update(entity);
        }
    }
}

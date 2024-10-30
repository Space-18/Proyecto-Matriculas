using Matriculas.Domain.Entities.Commons;
using System.Linq.Expressions;

namespace Matriculas.Application.Contracts.Persistence.Commons
{
    public interface IBaseRepository<T> where T : BaseModel
    {
        Task<List<T>> GetAllAsync();
        Task<T?> GetOneByAsync(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> GetAll();
        IQueryable<T> GetOneBy(Expression<Func<T, bool>> predicate);
    }
}

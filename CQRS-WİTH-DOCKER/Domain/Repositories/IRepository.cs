using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRS_WİTH_DOCKER.Domain.Repositories.Implementations
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> ListAsync();
        Task<T> FindByIdAsync(int id);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

using CQRS_WİTH_DOCKER.DAL;
using CQRS_WİTH_DOCKER.Domain.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRS_WİTH_DOCKER.Domain.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        async Task<IEnumerable<T>> IRepository<T>.ListAsync()
        {
            return await _context.Set<T>()
                    .AsNoTracking()
                    .ToListAsync();
        }

        async Task<T> IRepository<T>.FindByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        async Task IRepository<T>.AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        void IRepository<T>.Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        void IRepository<T>.Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
    }
}

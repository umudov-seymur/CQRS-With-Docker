using CQRS_WİTH_DOCKER.DAL;
using CQRS_WİTH_DOCKER.Domain.Repositories.Implementations;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_WİTH_DOCKER.Domain.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        private IUserRepository _userRepository;
        public IUserRepository UserRepository => _userRepository ??= new UserRepository(_context);

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task SaveAsync(CancellationToken token)
        {
            await _context.SaveChangesAsync(token);
        }
    }
}

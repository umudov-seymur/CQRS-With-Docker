using CQRS_WİTH_DOCKER.DAL;
using CQRS_WİTH_DOCKER.Domain.Models;
using CQRS_WİTH_DOCKER.Domain.Repositories.Implementations;

namespace CQRS_WİTH_DOCKER.Domain.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {

        }
    }
}

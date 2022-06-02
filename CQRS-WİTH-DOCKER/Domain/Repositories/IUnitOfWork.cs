using CQRS_WİTH_DOCKER.Domain.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_WİTH_DOCKER.Domain.Repositories.Implementations
{
    public interface IUnitOfWork 
    {
        IUserRepository UserRepository { get; }
        Task SaveAsync();
        Task SaveAsync(CancellationToken token);
    }
}

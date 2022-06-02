using CQRS_WİTH_DOCKER.Domain.Models;
using CQRS_WİTH_DOCKER.Domain.Repositories.Implementations;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_WİTH_DOCKER.Domain.Commands.Users
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, User>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateUserCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                Name = request.Name,
                Age = request.Age
            };

            await _unitOfWork.UserRepository.AddAsync(user);
            await _unitOfWork.SaveAsync();

            return user;
        }
    }
}

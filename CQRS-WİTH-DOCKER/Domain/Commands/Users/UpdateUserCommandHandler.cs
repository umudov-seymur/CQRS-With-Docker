using CQRS_WİTH_DOCKER.Domain.Communication;
using CQRS_WİTH_DOCKER.Domain.Models;
using CQRS_WİTH_DOCKER.Domain.Repositories.Implementations;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_WİTH_DOCKER.Domain.Commands.Users
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Response<User>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateUserCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<User>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.UserRepository.FindByIdAsync(request.Id);

            if (user is null)
            {
                return new Response<User>("User Not Found");
            }

            user.Name = request.Name;
            user.Age = request.Age;

            _unitOfWork.UserRepository.Update(user);
            await _unitOfWork.SaveAsync();

            return new Response<User>(user);
        }
    }
}

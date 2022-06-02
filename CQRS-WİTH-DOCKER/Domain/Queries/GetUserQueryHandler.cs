using CQRS_WİTH_DOCKER.Domain.Models;
using CQRS_WİTH_DOCKER.Domain.Repositories.Implementations;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_WİTH_DOCKER.Domain.Queries
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, User>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetUserQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<User> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            if (request.UserId <= 0)
            {
                throw new ArgumentException(nameof(request.UserId));
            }

            return await _unitOfWork.UserRepository.FindByIdAsync(request.UserId);
        }
    }
}

using CQRS_WİTH_DOCKER.Domain.Models;
using CQRS_WİTH_DOCKER.Domain.Repositories.Implementations;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_WİTH_DOCKER.Domain.Queries
{
    public class ListUsersQueryHandler : IRequestHandler<ListUsersQuery, IEnumerable<User>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ListUsersQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<User>> Handle(ListUsersQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.UserRepository.ListAsync();
        }
    }
}

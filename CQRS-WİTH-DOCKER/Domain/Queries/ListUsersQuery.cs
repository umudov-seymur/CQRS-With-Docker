using CQRS_WİTH_DOCKER.Domain.Models;
using MediatR;
using System.Collections;
using System.Collections.Generic;

namespace CQRS_WİTH_DOCKER.Domain.Queries
{
    public class ListUsersQuery : IRequest<IEnumerable<User>>
    {

    }
}

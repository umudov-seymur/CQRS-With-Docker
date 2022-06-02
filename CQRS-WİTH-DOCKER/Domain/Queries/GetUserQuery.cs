using CQRS_WİTH_DOCKER.Domain.Models;
using MediatR;

namespace CQRS_WİTH_DOCKER.Domain.Queries
{
    public class GetUserQuery : IRequest<User>
    {
        public int UserId { get; set; }

        public GetUserQuery(int userId)
        {
            UserId = userId;
        }
    }
}

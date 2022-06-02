using CQRS_WİTH_DOCKER.Domain.Communication;
using CQRS_WİTH_DOCKER.Domain.Models;
using MediatR;

namespace CQRS_WİTH_DOCKER.Domain.Commands.Users
{
    public class DeleteUserCommand : IRequest<Response<User>>
    {
        public int Id { get; set; }

        public DeleteUserCommand(int id)
        {
            Id = id;
        }
    }
}

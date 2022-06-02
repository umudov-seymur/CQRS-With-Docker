using CQRS_WİTH_DOCKER.Domain.Communication;
using CQRS_WİTH_DOCKER.Domain.Models;
using MediatR;

namespace CQRS_WİTH_DOCKER.Domain.Commands.Users
{
    public class UpdateUserCommand : IRequest<Response<User>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public UpdateUserCommand(int id, string name, int age)
        {
            Id = id;
            Name = Name;
            Age = Age;
        }
    }
}

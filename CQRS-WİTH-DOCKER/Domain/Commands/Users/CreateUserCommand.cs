using CQRS_WİTH_DOCKER.Domain.Models;
using MediatR;

namespace CQRS_WİTH_DOCKER.Domain.Commands.Users
{
    public class CreateUserCommand : IRequest<User>
    {
        public string Name { get; private set; }

        public int Age { get; private set; }

        public CreateUserCommand(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}

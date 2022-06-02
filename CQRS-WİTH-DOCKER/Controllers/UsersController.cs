using CQRS_WİTH_DOCKER.Domain.Commands.Users;
using CQRS_WİTH_DOCKER.Domain.Communication;
using CQRS_WİTH_DOCKER.Domain.Models;
using CQRS_WİTH_DOCKER.Domain.Queries;
using CQRS_WİTH_DOCKER.DTOs.Users;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRS_WİTH_DOCKER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> ListAsync()
        {
            return await _mediator.Send(new ListUsersQuery());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var user = await _mediator.Send(new GetUserQuery(id));

            if (user is null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] UserPostDto userDto)
        {
            var user = await _mediator.Send(new CreateUserCommand(userDto.Name, userDto.Age));
            return Created($"/api/users/{user.Id}", user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] UserPutDto userDto)
        {
            var user = await _mediator.Send(new UpdateUserCommand(id, userDto.Name, userDto.Age));
            return ProducesUserResponse(user);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var user = await _mediator.Send(new DeleteUserCommand(id));
            return ProducesUserResponse(user);
        }

        private IActionResult ProducesUserResponse(Response<User> response)
        {
            if (!response.Success)
            {
                return BadRequest(response.Message);
            }

            return Ok(response.Data);
        }
    }
}

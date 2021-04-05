using Commads.API.Domain.Commands.Requests;
using Commads.API.Domain.Commands.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Commads.API.Controllers
{
	[ApiController]
	[Route("v1/users")]
	public class UserController : ControllerBase
	{
		[HttpPost]
		[Route("create")]
		public Task<CreateUserResponse> Create
			(
				[FromServices]IMediator mediator,
				[FromBody]CreateUserRequest command

			)
		{
			return mediator.Send(command);
		}
	}
}

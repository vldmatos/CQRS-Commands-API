using Commads.API.Domain.Commands.Handlers;
using Commads.API.Domain.Commands.Requests;
using Commads.API.Domain.Commands.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Commads.API.Controllers
{
	[ApiController]
	[Route("v1/users")]
	public class UserController : ControllerBase
	{
		[HttpPost]
		[Route("create")]
		public CreateUserResponse Create
			(
				[FromServices]ICreateUserHandler handler,
				[FromBody]CreateUserRequest command

			)
		{
			return handler.Handle(command);
		}
	}
}

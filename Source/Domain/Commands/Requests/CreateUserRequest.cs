using Commads.API.Domain.Commands.Responses;
using MediatR;

namespace Commads.API.Domain.Commands.Requests
{
	public class CreateUserRequest : IRequest<CreateUserResponse>
	{
		public string Name { get; init; }

		public string Email { get; init; }
	}
}

using Commads.API.Domain.Commands.Requests;
using Commads.API.Domain.Commands.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Commads.API.Domain.Commands.Handlers
{
	public class CreateUserHandler : IRequestHandler<CreateUserRequest, CreateUserResponse>
	{
		public Task<CreateUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
		{
			//Business Rule 1
			//Business Rule 2
			//Business Rule 3

			var response = new CreateUserResponse
			{
				Id = Guid.NewGuid(),
				Name = request.Name,
				Email = request.Email,
				Date = DateTime.Now
			};

			return Task.FromResult(response);
		}
	}	
}

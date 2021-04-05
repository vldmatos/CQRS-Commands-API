using Commads.API.Domain.Commands.Requests;
using Commads.API.Domain.Commands.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commads.API.Domain.Commands.Handlers
{

	public interface ICreateUserHandler
	{
		CreateUserResponse Handle(CreateUserRequest request);
	}

	public class CreateUserHandler : ICreateUserHandler
	{
		public CreateUserResponse Handle(CreateUserRequest request)
		{
			//Business Rule 1
			//Business Rule 2
			//Business Rule 3

			return new CreateUserResponse
			{
				Id = Guid.NewGuid(),
				Name = request.Name,
				Email = request.Email,
				Date = DateTime.Now
			};
		}
	}	
}

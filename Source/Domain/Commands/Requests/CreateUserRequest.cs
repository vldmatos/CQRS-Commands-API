using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commads.API.Domain.Commands.Requests
{
	public class CreateUserRequest
	{
		public string Name { get; init; }

		public string Email { get; init; }
	}
}

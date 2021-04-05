using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commads.API.Domain.Commands.Responses
{
	public class CreateUserResponse
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string Email { get; set; }

		public DateTime Date { get; set; }
	}
}

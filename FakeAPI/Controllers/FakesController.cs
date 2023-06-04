using System;
using Microsoft.AspNetCore.Mvc;

namespace FakeAPI.Controllers
{
	[ApiController]
	[Route("api/fakes")]
	public class FakesController : ControllerBase
	{
		public FakesController()
		{
		}

		[HttpPost]
		public IActionResult Post(FakeCustomer customer)
		{
			return NoContent();
		}
	}

	public class FakeCustomer
	{
		public string FullName { get; set; }
		public string Document { get; set; }
	}
}


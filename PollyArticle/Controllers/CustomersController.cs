using System;
using Microsoft.AspNetCore.Mvc;
using PollyArticle.Models;
using PollyArticle.Services;

namespace PollyArticle.Controllers
{
	[ApiController]
	[Route("api/customers")]
	public class CustomersController : ControllerBase
	{
        private readonly IMyIntegrationService _service;

        public CustomersController(IMyIntegrationService service)
		{
            _service = service;
        }

		[HttpPost]
		public async Task<IActionResult> Post(CustomerIntegrationModel customer)
		{
			await _service.Sync(customer);

			return Ok();
		} 
	}
}


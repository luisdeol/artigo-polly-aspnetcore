using System;
using PollyArticle.Models;

namespace PollyArticle.Services
{
	public interface IMyIntegrationService
	{
		Task<bool> Sync(CustomerIntegrationModel model);
	}
}


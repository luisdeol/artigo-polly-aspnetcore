using System;
using PollyArticle.Models;

namespace PollyArticle.Services
{
	public class MyIntegrationService : IMyIntegrationService
	{
        private readonly HttpClient _httpClient;

        public MyIntegrationService(HttpClient httpClient)
		{
            _httpClient = httpClient;
        }

        public async Task<bool> Sync(CustomerIntegrationModel model)
        {
            var response = await _httpClient.PostAsJsonAsync($"http://localhost:5105/api/fakes/", model);

            return response.IsSuccessStatusCode;
        }
    }
}


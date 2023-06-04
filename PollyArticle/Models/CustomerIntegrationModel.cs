using System;
namespace PollyArticle.Models
{
	public class CustomerIntegrationModel
	{
		public CustomerIntegrationModel(string fullName, string document)
		{
			FullName = fullName;
			Document = document;
		}

		public string FullName { get; set; }
		public string Document { get; set; }
	}
}


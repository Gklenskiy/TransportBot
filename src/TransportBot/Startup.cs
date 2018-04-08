using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace TransportBot
{
	public class Startup
	{
		private readonly IConfigurationRoot _configuration;

		public Startup(IHostingEnvironment env)
		{
			_configuration = BuildConfiguration(env.ContentRootPath)
				.AddJsonFile($"appsettings.{env.EnvironmentName}.json", true)
				.Build();
		}

		public static IConfigurationBuilder BuildConfiguration(string contentRoot)
		{
			return new ConfigurationBuilder()
				.SetBasePath(contentRoot)
				.AddEnvironmentVariables("TransportBot_")
				.AddJsonFile("appsettings.json");
		}
	}
}
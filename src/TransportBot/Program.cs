using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace TransportBot
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "TransportBot";

			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>()
				.Build()
				.Run();
		}
	}
}
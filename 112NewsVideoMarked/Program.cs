using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using _112NewsVideoMarked.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace _112NewsVideoMarked
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var host = CreateWebHostBuilder(args).Build();

			using (var scope = host.Services.CreateScope())
			{
				var services = scope.ServiceProvider;
				var context = services.GetRequiredService<ApplicationDbContext>();
				context.Database.Migrate();

				// requires using Microsoft.Extensions.Configuration;
				IConfiguration config = host.Services.GetRequiredService<IConfiguration>();
				// Set password with the Secret Manager tool.
				// dotnet user-secrets set SeedUserPW <pw>

				string adminUserPw = config["SeedUserPW"];
				string adminUserMail = config.GetSection("DefaultAdmin")["AdminMail"];

				try
				{
					SeedUsersAndRoles.CreateRoles(services, adminUserMail, adminUserPw).Wait();
				}
				catch (Exception ex)
				{
					ILogger logger = services.GetRequiredService<ILogger<Program>>();
					logger.LogError(ex.Message, "An error occurred seeding the DB.");
				}
			}

			host.Run();
		}

		public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>()
				.UseKestrel(options =>
				{
					options.Limits.MaxRequestBodySize = null; // or a given limit
				});
	}
}

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _112NewsVideoMarked.Data
{
	public class SeedUsersAndRoles
	{
		public static async Task CreateRoles(IServiceProvider serviceProvider, string adminUserEmail, string adminUserPWD)
		{
			//initializing custom roles 
			var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
			var UserManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
			string[] roleNames = { "Administrator", "Fotograf", "Kunde" };
			IdentityResult roleResult;

			foreach (var roleName in roleNames)
			{
				var roleExist = await RoleManager.RoleExistsAsync(roleName);

				if (!roleExist)
				{
					//create the roles and seed them to the database: Question 1
					roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
				}
			}

			//Here you could create a super user who will maintain the web app
			var poweruser = new IdentityUser
			{
				UserName = adminUserEmail,
				Email = adminUserEmail,
			};

			//Ensure you have these values in your appsettings.json file
			var _user = await UserManager.FindByEmailAsync(adminUserEmail);

			if (_user == null)
			{
				var createPowerUser = await UserManager.CreateAsync(poweruser, adminUserPWD);
				if (createPowerUser.Succeeded)
				{
					//here we tie the new user to the role
					await UserManager.AddToRoleAsync(poweruser, "Administrator");
				}
			}
		}
	}
}

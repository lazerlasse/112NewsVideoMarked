using _112NewsVideoMarked.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _112NewsVideoMarked.Pages.Cases
{
	public class Case_BasePageModel : PageModel
	{
		protected ApplicationDbContext Context { get; }
		protected IAuthorizationService AuthorizationService { get; }
		protected UserManager<IdentityUser> UserManager { get; }

		public Case_BasePageModel(
			ApplicationDbContext context,
			IAuthorizationService authorizationService,
			UserManager<IdentityUser> userManager) : base()
		{
			Context = context;
			UserManager = userManager;
			AuthorizationService = authorizationService;
		}
	}
}

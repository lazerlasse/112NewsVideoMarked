using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using _112NewsVideoMarked.Data;
using _112NewsVideoMarked.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace _112NewsVideoMarked.Pages.Cases
{
    public class CreateModel : Case_BasePageModel
    {
        public CreateModel(ApplicationDbContext context, IAuthorizationService authorizationService, UserManager<IdentityUser> userManager)
			: base(context, authorizationService, userManager)
        {
        }

		[BindProperty]
		public CaseContent CaseContent { get; set; }

		[Display(Name = "Fotograf")]
		public string UserName { get; private set; }

		private string UserID { get; set; }

		public IActionResult OnGet()
		{
			// Get the current users id and username...
			UserID = UserManager.GetUserId(User);
			UserName = UserManager.GetUserName(User);

			// Check userID not null...
			if (UserID == null)
			{
				return NotFound($"Kunne ikke indlæse bruger med ID '{UserManager.GetUserId(User)}'.");
			}

			return Page();
		}

		public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

			// Try set the CaseContent Photografer from current users username...
			var userName = UserManager.GetUserName(User);
			if (userName == null)
			{
				throw new InvalidOperationException("Der opstod en uventet fejl i forsøget på at indlæse brugeren");
			}
			else
			{
				CaseContent.Photographer = userName;
			}

			// Try set the OwnerId from current users id...
			var userID = UserManager.GetUserId(User);
			if (userID == null)
			{
				throw new InvalidOperationException("Der opstod en uventet fejl i forsøget på at indlæse brugeren");
			}
			else
			{
				CaseContent.OwnerID = userID;
			}

			// Add content to DB Context and save change...
            Context.CaseContent.Add(CaseContent);
            await Context.SaveChangesAsync();

			// If succeded. proceed to upload page...
            return RedirectToPage("./MediaUpload", new { id = CaseContent.CaseContentID });
        }
    }
}
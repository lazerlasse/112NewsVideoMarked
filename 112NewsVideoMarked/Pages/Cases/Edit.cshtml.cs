using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _112NewsVideoMarked.Data;
using _112NewsVideoMarked.Models;

namespace _112NewsVideoMarked.Pages.Cases
{
    public class EditModel : PageModel
    {
        private readonly _112NewsVideoMarked.Data.ApplicationDbContext _context;

        public EditModel(_112NewsVideoMarked.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CaseContent CaseContent { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CaseContent = await _context.CaseContent.FirstOrDefaultAsync(m => m.CaseContentID == id);

            if (CaseContent == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CaseContent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CaseContentExists(CaseContent.CaseContentID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CaseContentExists(int id)
        {
            return _context.CaseContent.Any(e => e.CaseContentID == id);
        }
    }
}

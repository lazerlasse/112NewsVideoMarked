using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _112NewsVideoMarked.Data;
using _112NewsVideoMarked.Models;

namespace _112NewsVideoMarked.Pages.Cases
{
    public class DeleteModel : PageModel
    {
        private readonly _112NewsVideoMarked.Data.ApplicationDbContext _context;

        public DeleteModel(_112NewsVideoMarked.Data.ApplicationDbContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CaseContent = await _context.CaseContent.FindAsync(id);

            if (CaseContent != null)
            {
                _context.CaseContent.Remove(CaseContent);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

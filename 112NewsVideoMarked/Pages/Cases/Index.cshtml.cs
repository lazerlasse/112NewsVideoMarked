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
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<CaseContent> CaseContent { get;set; }

        public async Task OnGetAsync()
        {
            CaseContent = await _context.CaseContent.ToListAsync();
        }
    }
}

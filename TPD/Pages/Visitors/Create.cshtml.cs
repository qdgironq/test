using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TPD.Data;
using TPD.Models;

namespace TPD.Pages.Visitors
{
    public class CreateModel : PageModel
    {
        private readonly TPD.Data.ApplicationDbContext _context;

        public CreateModel(TPD.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Visitor Visitor { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Visitors.Add(Visitor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TPD.Data;
using TPD.Models;

namespace TPD.Pages.Attractions
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
        ViewData["AttractionTypeId"] = new SelectList(_context.AttractionTypes, "Id", "Name");
        ViewData["LocationId"] = new SelectList(_context.Locaitons, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Attraction Attraction { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attractions.Add(Attraction);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
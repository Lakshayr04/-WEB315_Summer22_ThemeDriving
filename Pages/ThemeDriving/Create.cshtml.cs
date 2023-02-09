using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using _WEB315_Summer22_ThemeDriving.Models;

namespace _WEB315_Summer22_ThemeDriving.Pages_ThemeDriving
{
    public class CreateModel : PageModel
    {
        private readonly ThemeDrivingContext _context;

        public CreateModel(ThemeDrivingContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ThemeDriving ThemeDriving { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ThemeDriving.Add(ThemeDriving);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _WEB315_Summer22_ThemeDriving.Models;

namespace _WEB315_Summer22_ThemeDriving.Pages_ThemeDriving
{
    public class EditModel : PageModel
    {
        private readonly ThemeDrivingContext _context;

        public EditModel(ThemeDrivingContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ThemeDriving ThemeDriving { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ThemeDriving = await _context.ThemeDriving.FirstOrDefaultAsync(m => m.ID == id);

            if (ThemeDriving == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ThemeDriving).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ThemeDrivingExists(ThemeDriving.ID))
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

        private bool ThemeDrivingExists(int id)
        {
            return _context.ThemeDriving.Any(e => e.ID == id);
        }
    }
}

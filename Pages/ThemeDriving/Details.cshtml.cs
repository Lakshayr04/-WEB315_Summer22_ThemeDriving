using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _WEB315_Summer22_ThemeDriving.Models;

namespace _WEB315_Summer22_ThemeDriving.Pages_ThemeDriving
{
    public class DetailsModel : PageModel
    {
        private readonly ThemeDrivingContext _context;

        public DetailsModel(ThemeDrivingContext context)
        {
            _context = context;
        }

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
    }
}

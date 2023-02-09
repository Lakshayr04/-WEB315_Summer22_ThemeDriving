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
    public class IndexModel : PageModel
    {
        private readonly ThemeDrivingContext _context;

        public IndexModel(ThemeDrivingContext context)
        {
            _context = context;
        }

        public IList<ThemeDriving> ThemeDriving { get;set; }

        public async Task OnGetAsync()
        {
            ThemeDriving = await _context.ThemeDriving.ToListAsync();
        }
    }
}

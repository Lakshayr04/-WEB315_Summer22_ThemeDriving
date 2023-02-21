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
    public class IndexModel : PageModel
    {
        private readonly ThemeDrivingContext _context;

        public IndexModel(ThemeDrivingContext context)
        {
            _context = context;
        }

        public IList<ThemeDriving> ThemeDriving { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString {get; set; }

        public SelectList Drive {get; set; }
        [BindProperty(SupportsGet = true)]
        public String Mode {get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> RouteQuery = from r in _context.ThemeDriving
                                orderby r.Route
                                select r.Route;

            var Vehicles = from c in _context.ThemeDriving
                        select c;

            if (!string.IsNullOrEmpty(SearchString))            
            {
                Vehicles = Vehicles.Where(s => s.Route.Contains(SearchString)  || s.colour.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(Mode))
            {
                Vehicles = Vehicles.Where(x => x.Route == Mode);
            }
            Drive = new SelectList(await RouteQuery.Distinct().ToListAsync());
            ThemeDriving = await Vehicles.ToListAsync();
        }
    }
}

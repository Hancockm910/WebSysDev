using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gourmet_Pizza.Data;
using Gourmet_Pizza.Model;

namespace Gourmet_Pizza.Pages.Pizzas
{
    public class DetailsModel : PageModel
    {
        private readonly Gourmet_Pizza.Data.Gourmet_PizzaContext _context;

        public DetailsModel(Gourmet_Pizza.Data.Gourmet_PizzaContext context)
        {
            _context = context;
        }

        public Pizza Pizza { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pizza = await _context.Pizza.FirstOrDefaultAsync(m => m.PizzaID == id);

            if (Pizza == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

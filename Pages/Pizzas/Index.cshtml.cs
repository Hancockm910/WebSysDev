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
    public class IndexModel : PageModel
    {
        private readonly Gourmet_Pizza.Data.Gourmet_PizzaContext _context;

        public IndexModel(Gourmet_Pizza.Data.Gourmet_PizzaContext context)
        {
            _context = context;
        }

        public IList<Pizza> Pizza { get;set; }

        public async Task OnGetAsync()
        {
            Pizza = await _context.Pizza.ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gourmet_Pizza.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Gourmet_Pizza.Pages.Pizzas
{
    public class PurchaseModel : PageModel
    {
        private readonly Gourmet_Pizza.Data.Gourmet_PizzaContext _context;

        public PurchaseModel(Gourmet_Pizza.Data.Gourmet_PizzaContext context)
        {
            _context = context;
        }

        public SelectList TitleList { get; set; }
        [BindProperty(SupportsGet = true)]
        public PizzaPurchase PizzaPurchase { get; set; }
        public IActionResult OnGet()
        {
            // Obtain values for the <select> list in web form
            TitleList = new SelectList(_context.Pizza, "Name", "Name");

            // Display the page
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Obtain values for the <select> list in web form
            TitleList = new SelectList(_context.Pizza, "Name", "Name");

            if (!ModelState.IsValid)  // validate user input
            {
                return Page();
            }
            ViewData["CCard"] = PizzaPurchase.CreditCard ;
            var pizza = await _context.Pizza.FirstOrDefaultAsync(m => m.Name == PizzaPurchase.PizzaName);
            ViewData["TotalPrice"] = pizza.Price * PizzaPurchase.TicketCount;
            return Page();
        }
    }
}

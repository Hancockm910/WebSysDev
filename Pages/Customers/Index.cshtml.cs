using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gourmet_Pizza.Data;
using Gourmet_Pizza.Model;

namespace Gourmet_Pizza.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly Gourmet_Pizza.Data.Gourmet_PizzaContext _context;

        public IndexModel(Gourmet_Pizza.Data.Gourmet_PizzaContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            var Cust = (IQueryable<Customer>)_context.Customer;

            if(!String.IsNullOrEmpty(SearchString))
            {
                Cust = Cust.Where(s => s.lName.Contains(SearchString) || s.fName.Contains(SearchString));
            }

            Customer = await Cust.ToListAsync();
        }

    }
}

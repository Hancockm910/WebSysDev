using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gourmet_Pizza.Data;
using Gourmet_Pizza.Model;

namespace Gourmet_Pizza.Pages.Pizzas
{
    public class EditModel : PageModel
    {
        private readonly Gourmet_Pizza.Data.Gourmet_PizzaContext _context;

        public EditModel(Gourmet_Pizza.Data.Gourmet_PizzaContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Pizza).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PizzaExists(Pizza.PizzaID))
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

        private bool PizzaExists(int id)
        {
            return _context.Pizza.Any(e => e.PizzaID == id);
        }
    }
}

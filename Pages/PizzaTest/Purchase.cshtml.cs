using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Gourmet_Pizza.Pages.PizzaTest
{
    public class PurchaseModel : PageModel
    {
        public void OnGet(int PizzaType, int PizzaCount)
        {
            if (PizzaType == 1)
            {
                ViewData["Name"] = "BBQ Beef";
                ViewData["Price"] = PizzaCount * 10.5;
            }
            else if (PizzaType == 2)
            {
                ViewData["Name"] = "Chicken and Pineapple";
                ViewData["Price"] = PizzaCount * 8.5;
            }
            else if (PizzaType == 3)
            {
                ViewData["Name"] = "Pepperoni Feast";
                ViewData["Price"] = PizzaCount * 9;
            }
            else if (PizzaType == 4)
            {
                ViewData["Name"] = "Vegetarian";
                ViewData["Price"] = PizzaCount * 7;
            }
        }
    }
}


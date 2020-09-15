using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gourmet_Pizza.Model
{
    public class PizzaPurchase
    {
        [Display(Name = "Pizza Name")]
        public string PizzaName { get; set; }
        [Display(Name ="Number of Tickets")]
        [Range(1,10)]
        public int TicketCount { get; set; }
        [Required]
        [Display(Name ="Credit Card")]
        [RegularExpression(@"[0-9]{16}", ErrorMessage = "Please enter a valid 16 digit credit card.")]
        public string CreditCard { get; set; }
    }
}

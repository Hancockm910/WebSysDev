using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gourmet_Pizza.Model
{
    public class Pizza
    {
        public int PizzaID { get; set; }

        [Display(Name="Price Each")]
        [DataType(DataType.Currency)]
        [Range(5, 20)]
        public decimal Price { get; set; }

        [Required]
        [RegularExpression(@"[A-z_0-9 ]{3,19}")]
        public string Name { get; set; }
    }
}

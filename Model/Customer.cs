using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gourmet_Pizza.Model
{
    public class Customer
    {
        // (0[289][0-9]{2})|([1345689][0-9]{3})|(2[0-8][0-9]{2})|(290[0-9])|(291[0-4])|(7[0-4][0-9]{2})|(7[8-9][0-9]{2})

        public int ID { get; set; }
        [Required]
        [Display(Name = "Given Name Name")]
        [RegularExpression(@"[A-z-']{1,19}")]
        public string fName { get; set; }
        [Required]
        [Display(Name = "Family Name")]
        [RegularExpression(@"[A-z-']{1,19}")]
        public string lName { get; set; }
        [Display(Name ="Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string DoB { get; set; }
        [Key, Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^04[0-9]{2}[ ][0-9]{3}[ ][0-9]{3}$", ErrorMessage = "Please enter mobile number in the following format: 04XX XXX XXX")]
        public string Phone { get; set; }
        [Display(Name = "Postal Code")]
        [RegularExpression(@"(0[289][0-9]{2})|([134568][0-9]{3})|(2[0-8][0-9]{2})|(290[0-9])|(291[0-4])|(7[0-4][0-9]{2})|(7[8-9][0-9]{2})", ErrorMessage = "Please enter a valid 4 digit residential post code.")]
        public string PostCode { get; set; }

    }
}

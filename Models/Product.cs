using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoySaloon.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }


        [Display(Name = "Name")]
        public string ProductName { get; set; }

        [Display(Name = "Company ")]
        public int Company { get; set; }

        [Display(Name = "Charges")]
        public int Charges { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoySaloon.Models
{
    public class Clients
    {
        [Key]
        public int CustomerID { get; set; }

        [Display(Name = "Name")]
        public string CustomerName { get; set; }

        [Display(Name = "Contact Number ")]
        public int ContactNumber { get; set; }
        [Display(Name = "Charges")]
        public int Expenses { get; set; }
        //Foreign Key

    }
}

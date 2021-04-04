using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoySaloon.Models
{
    public class Saloon
    {
        [Key]
        public int SaloonID { get; set; }

        [Display(Name = "Name")]
        public string SaloonName { get; set; }
        [Display(Name = "Address")]
        public string SaloonAddress { get; set; }
        [Display(Name = "Phone Number")]
        public String Contact_Number { get; set; }

    }
}

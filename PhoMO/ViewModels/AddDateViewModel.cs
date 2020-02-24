using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace PhoMO.ViewModels
{
    public class AddDateViewModel
    {
        [Required]
        [Display(Name = "Date Photo Was Taken")]
        public string DateTime { get; set; }
    }
}
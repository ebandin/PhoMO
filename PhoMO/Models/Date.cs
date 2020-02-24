using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhoMO.Models
{
    public class Date
    {
        public int Id { get; set; }

        public string DateTime { get; set; }

        public IList<Photo> Photos { get; set; }
    }
}

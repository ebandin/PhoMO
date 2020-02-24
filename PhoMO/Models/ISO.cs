using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PhoMO.Models
{
    public class ISO
    {
        public int Id { get; set; }

        public ISO Iso { get; set; }

        public IList<Photo> Photos { get; set; }
    }
}
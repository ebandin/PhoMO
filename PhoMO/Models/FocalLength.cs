using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PhoMO.Models
{
    public class FocalLength
    {
        public int Id { get; set; }

        public ISO iso { get; set; }

        public IList<Photo> Photos { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PhoMO.Models
{
    public class ShutterSpeed
    {
        public int Id { get; set; }

        public ShutterSpeed Shutterspeed { get; set; }

        public IList<Photo> Photos { get; set; }
    }
}
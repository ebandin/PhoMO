using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoMO.Models
{
    public class Photo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int FocalLength { get; set; }
        public int ShutterSpeed { get; set; }
        public int ISO { get; set; }
        public List<Photo> Photos { get; set; }
        public int DateID { get; set; }
        public PhotoDate Date { get; set; }

        //public<IList<CheeseMenu> CheeseMenus { get; set; }
    }
}

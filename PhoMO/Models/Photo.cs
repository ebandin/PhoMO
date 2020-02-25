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

        [Required]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public PhotoDate DateTime { get; set; }

        [Required]
        public int FocalLength { get; set; }

        [Required]
        public int ShutterSpeed { get; set; }

        [Required]
        public int ISO { get; set; }

        public List<Photo> Photos { get; set; }

        public int DateID { get; set; }
        public PhotoDate Date { get; set; }

        //public<IList<CheeseMenu> CheeseMenus { get; set; }
    }
}

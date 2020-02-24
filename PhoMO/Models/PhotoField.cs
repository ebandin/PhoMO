using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhoMO.Models
{
    [Table("PhotoField")]
    public class PhotoField
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateTime { get; set; }

        public string FocalLength { get; set; }

        public string ShutterSpeed { get; set; }

        public int ISO { get; set; }

        public IList<PhotoField> Fields { get; set; }
    }
}

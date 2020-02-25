using PhoMO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace PhoMO.ViewModels
{
    public class AddEditPhotoViewModel : AddPhotoViewModel
    {
        public AddEditPhotoViewModel(IEnumerable<PhotoDate> dates) : base(dates)
        {
        }
        public AddEditPhotoViewModel() { }
        public int PhotoId { get; set; }

    }
}

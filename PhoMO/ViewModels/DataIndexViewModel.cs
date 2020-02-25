using System.Collections.Generic;
using PhoMO.Models;
namespace ContosoUniversity.ViewModels
{
    public class InstructorIndexData
    {
        public IEnumerable<Photo> Photos { get; set; }
        public IEnumerable<PhotoDate> photoDates { get; set; }
    }
}











//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using PhoMO.Models;

//namespace PhoMO.ViewModels
//{
//    public class SearchViewModel : AddPhotoViewModel
//    {
//        public List<Photo> Photos { get; set; }
//        public string DateTime { get; set; }

//        public SearchViewModel(PhotoDate date)
//        {
//            Dates = new List<dates>();
//            foreach (var date in dates)
//            {
//                Dates.Add(new SelectListItem
//                {
//                    Value = date.ID.ToString(),
//                    Text = date.DateTime

//                });
//            }
//        }

//    }
//}
﻿using PhoMO.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace PhoMO.ViewModels
{
    public class AddPhotoViewModel
    {
        [Required]
        [Display(Name = "Photo Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "You must give your Photo a date")]
        [Display(Name = "Date")]
        public int DateID { get; set; }
        public List<SelectListItem> Dates { get; set; }

        [Required(ErrorMessage = "You must give your Photo a Focal Length")]
        [Display (Name = "Focal Length")]
        public int FocalLength { get; set; }
        public List<SelectListItem> FocalLengths { get; set; }

        [Required(ErrorMessage = "You must give your Photo a Shutter Speed")]
        [Display(Name = "Shutter Speed")]
        public int Shutterspeed { get; set; }
        public List<SelectListItem> Shutterspeeds { get; set; }


        [Required(ErrorMessage = "You must give your Photo an ISO")]
        [Display(Name = "ISO")]
        public int Iso { get; set; }
        public List<SelectListItem> Isos { get; set; }

        public List<SelectListItem> PhotoDates { get; set; }
        

        public AddPhotoViewModel(IEnumerable<PhotoDate> dates)
        {
            Dates = new List<SelectListItem>();
            foreach (var date in dates)
            {
                Dates.Add(new SelectListItem
                {
                    Value = date.ID.ToString(),
                    Text = date.DateTime

                });
            }
        }
        public AddPhotoViewModel()
        {

        }
    }
}
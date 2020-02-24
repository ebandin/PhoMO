﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PhoMO.ViewModels
{
    public class AddPhotoViewModel
    {   
        [Required]
        [Display(Name = "Photo Name")]
        public string Name { get; set; }
    }
}
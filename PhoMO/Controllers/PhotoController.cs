using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhoMO.Data;
using PhoMO.Models;
using PhoMO.ViewModels;

namespace PhoMO.Controllers
{
    public class PhotoController : Controller
    {

        private readonly ApplicationDbContext context;

        public PhotoController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            List<PhotoField> photos = context.Fields.ToList();

            return View(photos);
        }

        //    [HttpPost]
        //    public IActionResult Add(AddFieldViewModel addFieldViewModel)
        //        if (ModelState.IsValid)
        //        {
        //        PhotoField newField = new PhotoField
        //        {
        //            Name = addFieldViewModel.Name

        //        };

        //    context.Photos.Add(newField);
        //        context.SaveChanges();

        //        return Redirect("/Photo");
        //}

        public IActionResult Add()
        {
            AddPhotoViewModel addPhotoViewModel = new AddPhotoViewModel();
            return View(addPhotoViewModel);
        }
        [HttpPost]
        public IActionResult Add(AddPhotoViewModel addPhotoViewModel)
        {
            if (ModelState.IsValid)
            {
                PhotoField newField = new PhotoField
                {
                    Name = addPhotoViewModel.Name
                }; context.Fields.Add(newField);
                context.SaveChanges(); return Redirect("/Field");
            }
            return View(addPhotoViewModel);
        }

    }
}
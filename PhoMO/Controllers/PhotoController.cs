using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            List<Photo> photos = context.Photos.Include(c=> c.Date).ToList();

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
            AddPhotoViewModel addPhotoViewModel = new AddPhotoViewModel(context.Dates.ToList());
            return View(addPhotoViewModel);
        }






[HttpPost]
        public IActionResult Add(AddPhotoViewModel addPhotoViewModel)
        {

            

            if (ModelState.IsValid)
            {

                PhotoDate newPhotoDate = context.Dates.Single(c => c.ID == addPhotoViewModel.DateID);


                Photo newPhoto = new Photo
                {
                    Name = addPhotoViewModel.Name,
                    FocalLength = addPhotoViewModel.FocalLength,
                    Date = newPhotoDate, 
                    ShutterSpeed = addPhotoViewModel.Shutterspeed,
                    ISO = addPhotoViewModel.Iso


                }; 
                
                context.Photos.Add(newPhoto);
                context.SaveChanges(); 

                return Redirect("/Photo");
            }
            return View(addPhotoViewModel);
        }

        public IActionResult Remove()
        {
            ViewBag.title = "Remove Photos";
            ViewBag.photos = context.Photos.ToList();
            return View();
        }


        [HttpPost]
        public IActionResult Remove(int[] photoIds)
        {
            foreach (int photoId in photoIds)
            {
                Photo thePhoto = context.Photos.Single(c => c.ID == photoId);
                context.Photos.Remove(thePhoto);
            }
            context.SaveChanges(); return Redirect("/");
        }


    }
}
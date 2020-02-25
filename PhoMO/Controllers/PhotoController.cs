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

        private ApplicationDbContext context;

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


        public IActionResult Edit(int photoId)
        {
            AddEditPhotoViewModel addEditPhotoViewModel = new AddEditPhotoViewModel(context.Dates.ToList());
            Photo photo = context.Photos.Single(c => c.ID == photoId);
            PhotoDate newPhotoDate = context.Dates.Single(c => c.ID == photo.DateID);
            
            addEditPhotoViewModel.PhotoId = photo.ID;
            addEditPhotoViewModel.Name = photo.Name;
            addEditPhotoViewModel.FocalLength = photo.FocalLength;
            addEditPhotoViewModel.DateID = photo.Date.ID;
            addEditPhotoViewModel.Iso = photo.ISO;
            addEditPhotoViewModel.Shutterspeed = photo.ShutterSpeed;

            return View(addEditPhotoViewModel);
        }


        [HttpPost]
        public IActionResult Edit(AddEditPhotoViewModel addEditPhotoViewModel)
        {
            var id = context.Photos.FirstOrDefault(c => c.ID == addEditPhotoViewModel.PhotoId);
            PhotoDate newPhotoDate = context.Dates.Single(c => c.ID == addEditPhotoViewModel.DateID);            

            if (id != null)
            {
                id.Name = addEditPhotoViewModel.Name;
                id.FocalLength = addEditPhotoViewModel.FocalLength;
                id.Date = newPhotoDate;
                id.ISO = addEditPhotoViewModel.Iso;
                id.ShutterSpeed = addEditPhotoViewModel.Shutterspeed;
                context.Photos.Update(id); 
                context.SaveChanges();
            }
            return Redirect("/");
        }

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
            context.SaveChanges(); 
            
            
            return Redirect("/");
        }

        public IActionResult Date(int id)
        {
            if (id == 0)
            {
                return Redirect("/Date");
            }
            PhotoDate theDate = context.Dates
                .Include(cat => cat.Photos)
                .Single(cat => cat.ID == id); 

            ViewBag.title = "Photos on this date: " + theDate.DateTime; 
            
            return View("Index", theDate.Photos);
        }


    }
}
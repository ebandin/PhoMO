using PhoMO.Data;
using PhoMO.Models;
using PhoMO.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoMO.Controllers
{
    public class DateController : Controller
    {
        private readonly ApplicationDbContext context;
        public DateController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            List<PhotoDate> dates = context.Dates.ToList(); return View(dates);
        }

        
        public IActionResult Add()
        {
            AddDateViewModel addDateViewModel = new AddDateViewModel();
            return View(addDateViewModel);
        }
        [HttpPost]
        public IActionResult Add(AddDateViewModel addCategoryViewModel)
        {
            if (ModelState.IsValid)
            { 
                PhotoDate newDate = new PhotoDate
                {
                    DateTime = addCategoryViewModel.DateTime
                }; context.Dates.Add(newDate);
                context.SaveChanges();
                return Redirect("/Date");
            }
            return View(addCategoryViewModel);
        }
    }
}
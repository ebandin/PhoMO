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
        
        
        //[HttpGet("[action]/{date}")]
      public ActionResult Index()
        //public List<SubscriberHistory> GetSubscriberHistory(string accountNumber)
        {
        //    SubscriberManager subsManager = new SubscriberManager();
        //    return subsManager.GetSubscriberHistoryByAccountNumber(accountNumber);
        //}

        //{


        //    var dates = from s in ApplicationDbContext
        //                       select s;

        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        students = students.Where(s => s.LastName.Contains(searchString)
        //                               || s.FirstMidName.Contains(searchString));
        //    }

        //   return View(dates.ToList());

        List<PhotoDate> dates = context.Dates.ToList(); 

        return View(dates);
        }
        
        //[HttpGet("Date")]
        //public IActionResult ListByDate(string date)
        //{
        //    if (!String.IsNullOrEmpty(date))
        //    {
        //        var dates = from s in Photo
        //                    select s;
        //        dates = dates.Where(s => s.DateID.Contains(date));
        //    }
        //    return View(dates.ToList());
        //}
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
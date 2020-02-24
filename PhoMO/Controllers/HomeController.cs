using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PhoMO.Data;
using PhoMO.Models;



namespace PhoMO.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            //if userid == 1 return view
            // else userid ==2 return notview
            _logger = logger;
        }

        public IActionResult Index()
        {



            Dictionary<string, string> actionChoices = new Dictionary<string, string>();
            actionChoices.Add("ListAll", "List All");
            actionChoices.Add("Search", "Search");
            actionChoices.Add("AddNew", "Add Photos");
            actionChoices.Add("FilePathBuilder", "The File Path Builder");
            //this is to get it to push
            ViewBag.actions = actionChoices;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Search()
        {
            //if (HttpContext.Session.GetString( "Type") == "user")
            // {


            return View("Search");
            //look for the table where the data is and return enumurables. 
            // }
            //else
            // {
            //redirect to login page
            // return View();
            //}
        }

        public IActionResult ListAll()
        {

            return View("ListAll");
        }
        public IActionResult FilePathBuilder()
        {
            return View("FilePathBuilder");
        }
        public IActionResult AddNew()
        {
            return View("AddNew");
        }

    }
}

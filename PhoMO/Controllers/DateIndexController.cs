






//using Microsoft.AspNetCore.Mvc;
//using PhoMO.Models;
//using PhoMO.Data;
//using PhoMO.ViewModels;


//namespace PhoMO.Controllers
//{
//    public class SearchController : Controller
//    {        // Our reference to the data store
        
        
//        private readonly ApplicationDbContext photoSearch; 

//        public SearchController(ApplicationDbContext dbContext)
//        {
//            photoSearch = dbContext;
//        }       
        
        
//        // Display the search form
//        public IActionResult Index()
//        {
//            SearchViewModel photosViewModel = new SearchViewModel();
//            photosViewModel.DateID = "Search";
//            return View(photosViewModel);
//        }      
        
//        // Process search submission and display search results
//        public IActionResult Results(SearchViewModel jobsViewModel)
//        {
//            if (jobsViewModel.Column.Equals(JobFieldType.All) || jobsViewModel.Value.Equals(""))
//            {
//                jobsViewModel.Jobs = jobData.FindByValue(jobsViewModel.Value);
//            }
//            else
//            {
//                jobsViewModel.Jobs = jobData.FindByColumnAndValue(jobsViewModel.Column, jobsViewModel.Value);
//            }
//            jobsViewModel.Title = "Search"; return View("Index", jobsViewModel);
//        }
//    }
//}
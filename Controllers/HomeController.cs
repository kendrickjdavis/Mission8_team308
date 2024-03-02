using Microsoft.AspNetCore.Mvc;
using Mission_8.Models;
using System.Diagnostics;

namespace Mission_8.Controllers
{
    public class HomeController : Controller
    {
        private ITaskRepository _repo;    

        public HomeController(ITaskRepository temp) 
        {
            _repo = temp;
        }

        // Start of my views


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Quadrant()
        {
            var blah = _repo.Tasks.ToList();
            
            return View(blah);
        }


        public IActionResult TaskForm()
        {
            return View();
        }


        // End of my views




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var blah = _repo.Tasks.Where(x => x.IsCompleted == false).ToList();

            return View(blah);
        }

        [HttpGet]
        public IActionResult DeleteTask(int ID)
        {
            var recordToDelete = _repo.Tasks
                .Single(x => x.TaskId == ID);

            return View("delConf", recordToDelete);
        }

        [HttpPost]
        public IActionResult DeleteTask(TaskModel task)
        {
            _repo.RemoveTask(task);


            return RedirectToAction("Quadrant"); 
        }


        [HttpGet]
        public IActionResult TaskForm()
        {
            return View(new TaskModel());
        }

        [HttpPost]
        public IActionResult TaskForm(TaskModel t)
        {
            if (ModelState.IsValid)
            {
                _repo.AddTask(t);
            }

            return View(new TaskModel());
        }

        // End of my views




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

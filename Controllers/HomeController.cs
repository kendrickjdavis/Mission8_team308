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
            var joinedData = _repo.Tasks
                .Where(x => x.IsCompleted == false)
                .Join(_repo.Categories,
                    task => task.CategoryId,
                    category => category.CategoryId,
                    (task, category) => new TaskModel // Use TaskModel directly
                    {
                        TaskId = task.TaskId,
                        TaskDescription = task.TaskDescription,
                        DueDate = task.DueDate,
                        CategoryId = task.CategoryId,
                        Category = category, // Include the Category object
                        QuadrantId = task.QuadrantId,
                        // Quadrant = task.Quadrant,
                        IsCompleted = task.IsCompleted
                    })
                .ToList();

            return View(joinedData);
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

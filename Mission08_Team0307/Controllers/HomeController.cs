using Microsoft.AspNetCore.Mvc;
using Mission08_Team0307.Models;
using System.Diagnostics;

namespace Mission08_Team0307.Controllers
{
    public class HomeController : Controller
    {
        private QuadrantContext _context;

        public HomeController(QuadrantContext temp)
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TaskForm()
        {
            return View(new TaskEntry());
        }

        [HttpPost]
        public IActionResult TaskForm(TaskEntry response)
        {
            if (ModelState.IsValid)
            {
                _context.Tasks.Add(response);
                _context.SaveChanges();

                return View("Confirmation", response);
            }
            else
            {
                return View(response);
            }
        }

        public IActionResult Quadrant()
        {
            
            return View();
        }
    }
}

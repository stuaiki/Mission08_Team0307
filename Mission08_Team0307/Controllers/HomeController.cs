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

        //return index view
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] //default
        public IActionResult TaskForm()
        {
            // return taskform and create new task entry form
            return View(new TaskEntry());
        }


        [HttpPost] //after post method
        public IActionResult TaskForm(TaskEntry response)
        {
            //Validation value
            if (ModelState.IsValid)
            {
                //add new task and save changes
                _context.Tasks.Add(response);
                _context.SaveChanges();

                //jump to confirmaiton view and bring values inside response
                return View("Confirmation", response);
            }
            else
            {
                //show inputted value and show error message for invalid value
                return View(response);
            }
        }

        public IActionResult Quadrant()
        {
            return View();
        }
    }
}

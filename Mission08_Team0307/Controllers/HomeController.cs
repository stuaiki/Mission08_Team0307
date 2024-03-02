using Microsoft.AspNetCore.Mvc;
using Mission08_Team0307.Models;
using System.Diagnostics;

namespace Mission08_Team0307.Controllers
{
    public class HomeController : Controller
    {
        private IQuadrantRepository _repo; // repository object

        public HomeController(IQuadrantRepository temp)
        {
            _repo = temp;
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
                _repo.AddTask(response);

                //jump to confirmaiton view and bring values inside response
                return View("Confirmation", response);
            }
            else
            {
                //show inputted value and show error message for invalid value
                return View(response);
            }
        }

        public IActionResult Quadrant() // send all incomplete tasks to the task table view
        {
            var tasks = _repo.Tasks
                .Where(x => x.Completed == false).ToList();

            return View(tasks);
        }

        [HttpGet]
        public IActionResult Update(int id) // retrieve task to edit and fill task view with the current information
        {
            var taskToEdit = _repo.Tasks
                .Single(x => x.TaskId == id);

            return View("TaskForm", taskToEdit);
        }

        [HttpPost]
        public IActionResult Update(TaskEntry updatedTask) // update task info and redirect to table with incomplete tasks
        {
            _repo.UpdateTask(updatedTask);

            return RedirectToAction("Quadrant");
        }

        [HttpGet]
        public IActionResult Delete(int id) //retrieve task to delete and send to view with delete confirmation
        {
            var taskToDelete = _repo.Tasks
                .Single(x => x.TaskId == id);

            return View(taskToDelete);
        }

        [HttpPost]
        public IActionResult Delete(TaskEntry deleteTask) // delete task from database and send user back to the table view
        {
            _repo.DeleteTask(deleteTask);

            return RedirectToAction("Quadrant");
        }
    }
}

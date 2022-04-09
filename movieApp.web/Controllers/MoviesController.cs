using Microsoft.AspNetCore.Mvc;

namespace movieApp.web.Controllers
{
    // controller
    public class MoviesController : Controller
    {
        // action
        public IActionResult Index()
        {
            return View();
        }

        // localhost:5000/movies/list
        public IActionResult List()
        {
            return View("Movies");
        }

        // localhost:5000/movies/details
        public string Details()
        {
            return "The Details of Movie";
        }
    }
}

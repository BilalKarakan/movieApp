using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using movieApp.web.Models;

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
            var filmListesi = new List<Movie>()
            {
                new Movie
                {
                    Title = "Film 1",
                    Description = "Açıklama 1",
                    Director = "Yönetmen 1",
                    Players = new string[] {"Oyuncu 1", "Oyuncu 2"}
                },
                new Movie 
                {
                    Title = "Film 2",
                    Description = "Açıklama 2",
                    Director = "Yönetmen 2",
                    Players = new string[] {"Oyuncu 1", "Oyuncu 2"}
                },
                new Movie
                {
                    Title = "Film 3",
                    Description = "Açıklama 3",
                    Director = "Yönetmen 3",
                    Players = new string[] {"Oyuncu 1", "Oyuncu 2"}
                }
            };
            return View("Movies", filmListesi);
        }

        // localhost:5000/movies/details
        public string Details()
        {
            return "The Details of Movie";
        }
    }
}

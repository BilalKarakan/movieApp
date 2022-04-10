using Microsoft.AspNetCore.Mvc;
using movieApp.web.Models;

namespace movieApp.web.Controllers
{
    public class HomeController : Controller
    {
        // public string Index()
        // {
        //    return "Anasayfa";
        // }

        public IActionResult Index()
        {
            string filmAdi = "Film Adı";
            string filmAciklama = "Filmin Açıklaması";
            string filmYonetmen = "Filmin Yönetmeni";
            string[] oyuncular = { "Oyuncu 1", "Oyuncu 2", "Oyuncu 3" };

            var movie = new Movie();

            movie.Title = filmAdi;
            movie.Description = filmAciklama;
            movie.Director = filmYonetmen;
            movie.Players = oyuncular;

            return View(movie);

            //ViewBag.FilmAdi = filmAdi;
            //ViewBag.FilmAciklama = filmAciklama;
            //ViewBag.FilmYonetmen = filmYonetmen;
            //ViewBag.Oyuncular = oyuncular;

            //return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}

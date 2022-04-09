using Microsoft.AspNetCore.Mvc;

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

            ViewBag.FilmAdi = filmAdi;
            ViewBag.FilmAciklama = filmAciklama;
            ViewBag.FilmYonetmen = filmYonetmen;
            ViewBag.Oyuncular = oyuncular;

            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}

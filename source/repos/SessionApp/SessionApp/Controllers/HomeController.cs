using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SessionApp.Models;
using System.Diagnostics;

namespace SessionApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Oturumu etkinleştir
            HttpContext.Session.SetString("StudentName", "John");
            HttpContext.Session.SetInt32("StudentId", 50);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

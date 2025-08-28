using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AVANCE_DESKTOP_FIGMA.Models; // This fixes the previous error

namespace AVANCE_DESKTOP_FIGMA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Action to display the home page with the search form
        public IActionResult Index()
        {
            return View();
        }

        // Action to display the registration page
        public IActionResult Register()
        {
            return View();
        }

        // Action to display the login page
        public IActionResult Login()
        {
            return View();
        }

        // Example action to handle search form submission
        // You would add your database search logic here
        public IActionResult SearchResults(string location, DateTime checkin, DateTime checkout, int children, int adults)
        {
            // For now, it will just return a simple view.
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
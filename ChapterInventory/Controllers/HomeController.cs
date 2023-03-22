using ChapterInventory.Data;
using ChapterInventory.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ChapterInventory.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationContext context;
        

        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(LoginUser loginUser)
        {
            var status = context.Users.Where(m => m.Username == loginUser.Username && m.Password == loginUser.Password).FirstOrDefault();
            if (status == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Regions");
            }
            
        }
        public IActionResult Regions()
        {
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
using Lab3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DateTime? lastVisitDate = HttpContext.Items[LastVisitCookie.CookieName] as DateTime?;
            if (lastVisitDate == null)
            {
                ViewBag.LastVisitDate = HttpContext.Items[LastVisitCookie.CookieName];
            } 
            else
            {
                ViewBag.LastVisitDate = lastVisitDate?.Date;
            }
            
            return View();
        }
    }
}
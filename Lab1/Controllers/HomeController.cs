using Lab1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Numerics;

namespace Laboratorium_1.Controllers
{
    public class HomeController : Controller
    {
        public enum Operators
        {
            ADD, SUB, MUL, DIV
        }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About(string author, int? id)
        {
            //string author = Request.Query["author"];

            ViewBag.Author = author + " " + id;
            return View();
        }

        public IActionResult Calculator(double x, double y, string op)
        {
            double result = 0;
            string oper = "";
            switch (op)
            {
                case "add":
                    {
                        result = x + y;
                        oper = "+";
                        break;
                    }
                case "sub":
                    {
                        result = x - y;
                        oper = "-";
                        break;
                    }
                case "mul":
                    {
                        result = x * y;
                        oper = "*";
                        break;
                    }
                case "div":
                    {
                        result = x / y;
                        oper = ":";
                        break;
                    }
            }

            ViewBag.Calculation = x.ToString() + " " + oper + " " + y.ToString() + " = " + result;
            return View();
        }

        public IActionResult Calc([FromQuery(Name = "operator")] Operators? op, double? x, double? y)
        {
            if (op == null || x == null || y == null)
            {
                return View("Error");
            }

            double? result = 0;
            string symbol = "";
            
            switch (op)
            {
                case Operators.ADD:
                    {
                        result = x + y;
                        symbol = "+";
                        break;
                    }
                case Operators.SUB:
                    {
                        result = x - y;
                        symbol = "-";
                        break;
                    }
                case Operators.MUL:
                    {
                        result = x * y;
                        symbol = "*";
                        break;
                    }
                case Operators.DIV:
                    {
                        result = x / y;
                        symbol = ":";
                        break;
                    }
            }

            ViewBag.Calc = x.ToString() + " " + symbol + " " + y.ToString() + " = " + result;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
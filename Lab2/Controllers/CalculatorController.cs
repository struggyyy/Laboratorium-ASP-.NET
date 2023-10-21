using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public enum Operators
        {
            ADD, SUB, MUL, DIV
        }
        public IActionResult Form()
        {
            return View();
        }

        public IActionResult Result([FromQuery(Name = "operator")] Operators? op, double? x, double? y)
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

            return View("Result");


        }
    }
}

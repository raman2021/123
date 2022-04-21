using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
         [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet]
        public double Addition(int lValue, int rValue)
        {
            return lValue + rValue;
        }


        [HttpGet]
        public double Subtraction(int lValue, int rValue)
        {
            return lValue - rValue;
        }


        [HttpGet]
        public double Multiplication(int lValue, int rValue)
        {
            return lValue * rValue;
        }


        [HttpGet]
        public double Division(int lValue, int rValue)
        {


            if (lValue != 0 || rValue != 0)
            {
                return lValue / rValue;

            }
            else
            {
                throw new ArgumentException();


            }



        }
        [HttpGet]

        public double Percentage(int lValue, int rValue)
        {
            return lValue % rValue;
            // return (number1 * number2) / 100;
        }
    }
}
/*{
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}*/

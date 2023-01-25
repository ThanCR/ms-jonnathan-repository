using ExceptionMaker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExceptionMaker.Controllers
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
            return View();
        }

        public IActionResult MathExceptionGeneration()
        {

            const int valueA = 10;
            const int valueB = 2;
            ViewBag.result = executeDivision(valueA, valueB - 2);
            return View();
        }

        public IActionResult StackOverflowExceptionGeneration()
        {
            executeOverflow(1);
            return View();
        }

        public IActionResult MemoryLeakGeneration() 
        {
            generateMemoryLeak();
            return View();    
        }

        private int executeDivision(int valueA, int valueB)
        {
            return valueA / valueB;
        }

        private void executeOverflow(int num)
        {
            int value = num++;
            executeOverflow(value);
        }

        public static void generateMemoryLeak()
        {
            string[] values = { };
           
            
            for (int x = 0;  values.Length < 10000000; x++)
            {
                values[x] = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
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
            loadItems();
        }

        private static void loadItems()
        {
            var list = new List<byte[]>();
            int x = 0;
            while (x < 900)
            {
                list.Add(new byte[10000000]); // Change the size here.
                Thread.Sleep(300); // Change the wait time here.
                x++;
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
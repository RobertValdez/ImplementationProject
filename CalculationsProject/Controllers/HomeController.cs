using CalculationsProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using ModelsLayer;
using ServicesLayer;
using System.Diagnostics;

namespace CalculationsProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISumar _Suma;
        private readonly IConsole_x _Console;

        public HomeController(ILogger<HomeController> logger, ISumar suma, IConsole_x console)
        {
            _logger = logger;
            _Suma = suma;
            _Console = console;
        }

        public IActionResult Index()
        {
            //int Result = _Suma.ScaleEnd();
            //ViewBag.Result = Result;
            List<Console_> ShowCons = _Console.ShowConsoles();

            return View("Index", ShowCons);
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
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PageCounterApp.Services;

namespace PageCounterApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IPageCounterService _pageCounterService;

        // The constructor accpets a page counting service
        public HomeController(IPageCounterService pageCounterService, ILogger<HomeController> logger)
        {
            _pageCounterService = pageCounterService;
            _logger = logger;
        }

        // A method that counts the views on the "Home" page
        public IActionResult Index()
        {
            int pageCount = _pageCounterService.IncrementPageCount("Home");
            return View("Index",pageCount);
        }
        // A method that counts the views on the "Second Page" page
        public IActionResult SecondPage()
        {
            int pageCount = _pageCounterService.IncrementPageCount("Second Page");
            return View("SecondPage", pageCount);
        }
    }
}
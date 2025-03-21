using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Progetto_BE_S6.Services;
using Progetto_BE_S6.ViewModel;

namespace Progetto_BE_S6.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HomeServices _homeServices;

        public HomeController(ILogger<HomeController> logger , HomeServices homeServices)
        {
            _logger = logger;
            _homeServices = homeServices;
        }

        public async Task<IActionResult> Index()
        {
            var Lista = await _homeServices.getCamere();
            return View(Lista);
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

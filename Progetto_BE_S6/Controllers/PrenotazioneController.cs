using Microsoft.AspNetCore.Mvc;
using Progetto_BE_S6.Services;

namespace Progetto_BE_S6.Controllers
{
    public class PrenotazioneController : Controller
    {
        private readonly PrenotazioneServices _prenotazioneServices;
        public PrenotazioneController(PrenotazioneServices prenotazioneServices)
        {
            _prenotazioneServices = prenotazioneServices;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}

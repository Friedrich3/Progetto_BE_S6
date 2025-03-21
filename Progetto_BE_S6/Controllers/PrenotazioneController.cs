using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Progetto_BE_S6.Models;
using Progetto_BE_S6.Services;
using Progetto_BE_S6.ViewModel;

namespace Progetto_BE_S6.Controllers
{
    [Authorize]
    public class PrenotazioneController : Controller
    {
        private readonly PrenotazioneServices _prenotazioneServices;
        public PrenotazioneController(PrenotazioneServices prenotazioneServices)
        {
            _prenotazioneServices = prenotazioneServices;
        }


        public  IActionResult Index()
        {
            return View();
        }
        [HttpGet("Prenotazione/GetAll")]
        public async Task<IActionResult> GetAll()
        {
            List<Prenotazione> Lista = await _prenotazioneServices.GetAllPrenotazioni();
            return PartialView("_TabellaPrenotazioni", Lista);
        }

        [Authorize(Roles = "Admin, Supervisor")]
        public async Task<IActionResult> AddPrenotazione()
        {
            ViewBag.Camere = await _prenotazioneServices.getCamere();
            return View();
        }

        [Authorize(Roles = "Admin, Supervisor")]
        [HttpPost]
        public async Task<IActionResult> AddPrenotazione(AddPrenotazioneViewModel prenotazioneViewModel)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Errore nell' inserimento della prenotazione";
                return RedirectToAction("AddPrenotazione");
            }
            
            //var cliente = await _prenotazioneServices.GetClient(prenotazioneViewModel.Cliente.Email);

            var result = await _prenotazioneServices.CreateNew(prenotazioneViewModel, User);
               



            return RedirectToAction("Index");
        }
        





    }
}

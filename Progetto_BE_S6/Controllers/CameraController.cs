using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Progetto_BE_S6.Services;
using Progetto_BE_S6.ViewModel;

namespace Progetto_BE_S6.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CameraController : Controller
    {
        private readonly CameraServices _cameraServices;
        public CameraController(CameraServices cameraServices)
        {
            _cameraServices = cameraServices;
        }

        public async Task<IActionResult> Index()
        {
            var Lista = await _cameraServices.getAllCamere();
            

            return View(Lista);
        }
        public IActionResult AddCamera()
        {
            string[] ArrTipi = ["Singola", "Doppia", "Tripla", "Quadrupla"];
            ViewBag.TipiCamera = ArrTipi;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSave(AddCameraViewModel addCameraViewModel)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Errore nell' inserimento della camera";
                return RedirectToAction("AddCamera");
            }
            var isAdded = await _cameraServices.AddNew(addCameraViewModel);
            
            return RedirectToAction("Index");
        }
    }
}

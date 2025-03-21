using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Progetto_BE_S6.Data;
using Progetto_BE_S6.Models;
using Progetto_BE_S6.ViewModel;

namespace Progetto_BE_S6.Services
{
    public class CameraServices
    {
        private readonly ProgettoBES6 _context;
        public CameraServices(ProgettoBES6 context)
        {
            _context = context;
        }
        private async Task<bool> SaveAsync()
        {
            try
            {
                var righe = await _context.SaveChangesAsync();
                if (righe > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }


        public async Task<List<Camera>> getAllCamere()
        {
            var ListaCamere = new List<Camera>();
            ListaCamere = await _context.Camere.OrderBy(n => n.Numero).ToListAsync();
            return ListaCamere;
        }

        public async Task<bool> AddNew(AddCameraViewModel addCameraViewModel)
        {
            var camera = new Camera()
            {
                CameraId = Guid.NewGuid(),
                Numero = addCameraViewModel.Numero,
                Tipo = addCameraViewModel.Tipo,
                Prezzo = addCameraViewModel.Prezzo,
                IsDisponibile = addCameraViewModel.IsDisponibile,
            }; 

            await _context.Camere.AddAsync(camera);
            return await SaveAsync();
        }
    }
}

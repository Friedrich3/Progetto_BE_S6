using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Progetto_BE_S6.Data;
using Progetto_BE_S6.Models;
using Progetto_BE_S6.ViewModel;

namespace Progetto_BE_S6.Services
{
    public class PrenotazioneServices
    {
        private readonly ProgettoBES6 _context;
        private readonly UserManager<ApplicationUser> _userManager;
        

        public PrenotazioneServices(ProgettoBES6 context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
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

        public async Task<List<Prenotazione>> GetAllPrenotazioni()
        {
            var Lista = new List<Prenotazione>();

            Lista = await _context.Prenotazioni.Include(c => c.Camera).Include(c => c.Cliente).Where(p => p.Camera.IsDisponibile == false && p.Stato!= "checkedout").ToListAsync();

            return Lista;
        }

        public async Task<List<Camera>> getCamere()
        {
            var ListaCamere = new List<Camera>();

            ListaCamere = await _context.Camere.Where(d=> d.IsDisponibile== true).OrderBy(n=> n.Numero).ToListAsync();

            return ListaCamere;
        }

        public async Task<Cliente> GetClient(string email)
        {
            var cliente = _context.Clienti.FirstOrDefault(c => c.Email == email);
            if (cliente != null)
            {
                return cliente;
            }
            else
            {
                return cliente;
            }
        }

        public async Task<bool> CreateNew(AddPrenotazioneViewModel viewModel , ClaimsPrincipal utente)
        {
            var cameraSelected = await _context.Camere.FindAsync(viewModel.CameraId);
            var activeUser = await _userManager.FindByEmailAsync(utente.FindFirst(ClaimTypes.Email).Value);
            var isReg = await _context.Clienti.FirstOrDefaultAsync(p => p.Email == viewModel.Email);
            if (isReg != null)
            {
                var prenotazione = new Prenotazione()
                {
                    PrenotazioneId = Guid.NewGuid(),
                    ClienteId= isReg.ClienteId,
                    CameraId= cameraSelected.CameraId,
                    DataInizio = viewModel.DataInizio,
                    DataFine = viewModel.DataFine,
                    Stato = "confirmed",
                    CreatedBy = activeUser.Email
                };
                _context.Prenotazioni.Add(prenotazione);
                cameraSelected.IsDisponibile = false;
                return await SaveAsync();
            }
            else 
            {
                var cliente = new Cliente()
                {
                    ClienteId = Guid.NewGuid(),
                    Nome = viewModel.Nome,
                    Cognome = viewModel.Cognome,
                    Email = viewModel.Email,
                    Telefono = viewModel.Telefono,
                };
                var prenotazione = new Prenotazione()
                {
                    PrenotazioneId = Guid.NewGuid(),
                    ClienteId = cliente.ClienteId,
                    CameraId = cameraSelected.CameraId,
                    DataInizio = viewModel.DataInizio,
                    DataFine = viewModel.DataFine,
                    Stato = "confirmed",
                    CreatedBy = activeUser.Email
                };
                _context.Clienti.Add(cliente);
                _context.Prenotazioni.Add(prenotazione);
                cameraSelected.IsDisponibile = false;
                return await SaveAsync();
            }
        }

        
        public async Task<bool>CheckOut(Guid id)
        {
            var prenotazione = _context.Prenotazioni.FirstOrDefault(p => p.PrenotazioneId == id);
            prenotazione.Stato = "checkedout";
            return await SaveAsync();
        }
        public async Task<bool> CheckIn(Guid id)
        {
            var prenotazione = _context.Prenotazioni.FirstOrDefault(p => p.PrenotazioneId == id);
            prenotazione.Stato = "checkedin";
            return await SaveAsync();
        }

    }
}

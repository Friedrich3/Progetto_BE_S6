using System.Runtime.InteropServices;
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

        public async Task<Camera> CurrentCamera(Guid id)
        {
            var prenotazione = await _context.Prenotazioni.Include(c=>c.Camera).FirstOrDefaultAsync(p=> p.PrenotazioneId == id);
            var camera = new Camera()
            {
                CameraId = prenotazione.Camera.CameraId,
                Numero = prenotazione.Camera.Numero,
                Tipo = prenotazione.Camera.Tipo,
                Prezzo = prenotazione.Camera.Prezzo,
            };
            

            return camera;
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

        public async Task<bool> CheckIn(Guid id)
        {
            var prenotazione = _context.Prenotazioni.FirstOrDefault(p => p.PrenotazioneId == id);
            prenotazione.Stato = "checkedin";
            return await SaveAsync();
        }
        
        public async Task<bool>CheckOut(Guid id)
        {
            var prenotazione = await  _context.Prenotazioni.FirstOrDefaultAsync(p => p.PrenotazioneId == id);
            prenotazione.Stato = "checkedout";
            var camera = await _context.Camere.FirstOrDefaultAsync(p => p.CameraId == prenotazione.CameraId);
            camera.IsDisponibile = true;
            return await SaveAsync();
        }

        public async Task<EditPrenotazioneViewModel> GetPrenotazione(Guid id)
        {
            var prenotazione = await _context.Prenotazioni.Include(p=> p.Camera).Include(p=>p.Cliente).FirstOrDefaultAsync(p=> p.PrenotazioneId == id);
            if (prenotazione == null)
            {
                return null;
            }
            var model = new EditPrenotazioneViewModel()
            {
                PrenotazioneId = prenotazione.PrenotazioneId,
                ClienteId = prenotazione.ClienteId,
                CameraId = prenotazione.CameraId,
                DataInizio = prenotazione.DataInizio,
                DataFine = prenotazione.DataFine,
                Nome = prenotazione.Cliente.Nome,
                Cognome = prenotazione.Cliente.Cognome,
                Email = prenotazione.Cliente.Email,
                Telefono = prenotazione.Cliente.Telefono,

            };
            return model;
        }

        public async Task<bool> EditSave(EditPrenotazioneViewModel editPrenotazioneViewModel,Guid prenotazioneId, ClaimsPrincipal utente)
        {
            var activeUser = await _userManager.FindByEmailAsync(utente.FindFirst(ClaimTypes.Email).Value);
            var cameraSelected = await _context.Camere.FindAsync(editPrenotazioneViewModel.CameraId);
            var prenotazione = await _context.Prenotazioni.FirstOrDefaultAsync(p=> p.PrenotazioneId == prenotazioneId);
            var isReg = await _context.Clienti.FirstOrDefaultAsync(p => p.Email == editPrenotazioneViewModel.Email);
            if (prenotazione != null)
            {
                if(prenotazione.CameraId != editPrenotazioneViewModel.CameraId)
                {
                   var oldCamera = await _context.Camere.FirstOrDefaultAsync(p=> p.CameraId== prenotazione.CameraId);
                    oldCamera.IsDisponibile = true;
                }

                if (isReg != null)
                {
                    prenotazione.PrenotazioneId = editPrenotazioneViewModel.PrenotazioneId;
                    prenotazione.ClienteId = isReg.ClienteId;
                    prenotazione.CameraId = editPrenotazioneViewModel.CameraId;
                    prenotazione.DataInizio = editPrenotazioneViewModel.DataInizio;
                    prenotazione.DataFine = editPrenotazioneViewModel.DataFine;

                    cameraSelected.IsDisponibile = false;

                   
                    return await SaveAsync();
                }
                else
                {
                    var cliente = new Cliente()
                    {
                        ClienteId = Guid.NewGuid(),
                        Nome = editPrenotazioneViewModel.Nome,
                        Cognome = editPrenotazioneViewModel.Cognome,
                        Email = editPrenotazioneViewModel.Email,
                        Telefono = editPrenotazioneViewModel.Telefono,
                    };
                    prenotazione.PrenotazioneId = editPrenotazioneViewModel.PrenotazioneId;
                    prenotazione.ClienteId = cliente.ClienteId;
                    prenotazione.CameraId = editPrenotazioneViewModel.CameraId;
                    prenotazione.DataInizio = editPrenotazioneViewModel.DataInizio;
                    prenotazione.DataFine = editPrenotazioneViewModel.DataFine;

                    _context.Clienti.Add(cliente);
                    return await SaveAsync();
                }
            }
            else { return false; }



        }
        



    }
}

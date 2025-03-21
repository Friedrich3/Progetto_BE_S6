using Progetto_BE_S6.Data;
using Progetto_BE_S6.Models;

namespace Progetto_BE_S6.Services
{
    public class PrenotazioneServices
    {
        private readonly ProgettoBES6 _context;
        public PrenotazioneServices(ProgettoBES6 context)
        {
            _context = context;
        }


        public async Task<List<Camera>> getCamere()
        {
            var ListaCamere = new List<Camera>();

            //ListaCamere = await _context.

            return ListaCamere;
        }

    }
}

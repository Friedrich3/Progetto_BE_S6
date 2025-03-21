using Microsoft.EntityFrameworkCore;
using Progetto_BE_S6.Data;
using Progetto_BE_S6.Models;

namespace Progetto_BE_S6.Services
{
    public class HomeServices
    {
        private readonly ProgettoBES6 _context;

        public HomeServices(ProgettoBES6 context)
        {
            _context = context;
        }

        public async Task<List<Camera>> getCamere()
        {
            var Lista = new List<Camera>();
            Lista = await _context.Camere.Where(p=> p.IsDisponibile==true).ToListAsync();
            return Lista;
        }


    }
}

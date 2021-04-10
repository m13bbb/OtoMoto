using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OtoMoto.Database;
using OtoMoto.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OtoMoto.Pages.Offers
{
    public class IndexModel : PageModel
    {
        private readonly Context _context;

        public IndexModel(Context context)
        {
            _context = context;
        }

        public List<Offer> Offers { get; private set; } = new List<Offer>();
        public List<TypPaliwa> TypyPaliwa { get; private set; } = new List<TypPaliwa>();
        public List<NadwoziePojazdu> TypyNadwozia { get; private set; } = new List<NadwoziePojazdu>();

        public async Task OnGet()
        {
            Offers = await _context
                           .Offers
                           .Include(x => x.TypPaliwa)
                           .Include(x => x.NadwoziePojazdu)
                           .Include(x => x.Images)
                           .Include(x => x.CreatedBy)
                           .ToListAsync();
        }
    }
}
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OtoMoto.Database;
using OtoMoto.Models;
using OtoMoto.Models.Input;
using OtoMoto.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OtoMoto.Pages.Offers
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly Context _context;
        private readonly OfferService _service;

        public CreateModel(Context context, OfferService service)
        {
            _context = context;
            _service = service;
        }

        public List<TypPaliwa> TypyPaliwa { get; private set; } = new List<TypPaliwa>();

        public List<NadwoziePojazdu> TypyNadwozia { get; private set; } = new List<NadwoziePojazdu>();

        public async Task OnGet()
        {
            TypyPaliwa = await _context.TypyPaliwa.ToListAsync();
            TypyNadwozia = await _context.TypyNadwozia.ToListAsync();
        }

        public async Task<IActionResult> OnPost(CreateOffer input)
        {
            var result = await _service.CreateOffer(input, this.User.Identity.Name);

            if (!result.Success)
            {
                TempData["ErrorMessage"] = result.Error;
            }

            return RedirectToPage("Index");
        }
    }
}
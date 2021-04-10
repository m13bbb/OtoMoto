using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OtoMoto.Database;
using OtoMoto.Models;
using OtoMoto.Models.Input;
using OtoMoto.Services;

namespace OtoMoto.Pages.Offers
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly Context _context;
        private readonly OfferService _service;

        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        public Offer Offer { get; private set; }

        public DeleteModel(Context context, OfferService service)
        {
            _context = context;
            _service = service;
        }

        public async Task OnGet()
        {
            Offer = await _context.Offers.FirstOrDefaultAsync(x => x.Id == Id);
        }   
        
        public async Task<IActionResult> OnPost(SingleValue<Guid> Data)
        {
            var id = Data.Value;
            var isAdmin = this.User.IsInRole(Consts.AdminRoleName);
            await _service.RemoveOffer(id, this.User.Identity.Name, isAdmin);
            return RedirectToPage("/Offers/Index");
        }
    }
}
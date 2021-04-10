using Microsoft.EntityFrameworkCore;
using OtoMoto.Database;
using OtoMoto.Models;
using OtoMoto.Models.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtoMoto.Services
{
    public class OfferService
    {
        private readonly Context _context;

        public OfferService(Context context)
        {
            _context = context;
        }

        public async Task<(bool Success, string Error, Guid? Id)> CreateOffer(CreateOffer input, string UserEmail)
        {
            if (input == null)
            {
                return (false, "Dane są niekompletne", null);
            }

            if (string.IsNullOrWhiteSpace(input.Title) || string.IsNullOrWhiteSpace(input.Description))
            {
                return (false, "Tytuł oraz opis nie mogą być puste.", null);
            }

            var offer = new Offer();

            offer.Title = input.Title;
            offer.Description = input.Description;
            offer.Kontakt = input.Kontakt;
            offer.Make = input.Make;
            offer.Model = input.Model;
            offer.Przebieg = input.Przebieg;
            offer.Rocznik = input.Rocznik;
            offer.Cena = input.Cena;
            offer.NadwoziePojazdu = await _context.TypyNadwozia.FirstOrDefaultAsync(x => x.Id == input.NadwoziePojazduId);
            offer.TypPaliwa = await _context.TypyPaliwa.FirstAsync(x => x.Id == input.TypPaliwaId);
            offer.CreatedBy = await _context.Users.FirstOrDefaultAsync(x => x.Email == UserEmail);

            var images = await _context.Images.Where(x => input.Images.Contains(x.Id)).ToListAsync();

            offer.Images = images;

            await _context.AddAsync(offer);

            await _context.SaveChangesAsync();

            return (true, "", offer.Id);
        }

        public async Task RemoveOffer(Guid id, string email, bool isAdmin)
        {
            var offer = await _context
                              .Offers
                              .Include(x => x.NadwoziePojazdu)
                              .Include(x => x.TypPaliwa)
                              .Include(x => x.CreatedBy)
                              .Include(x => x.Images)
                              .FirstOrDefaultAsync(x => x.Id == id);

            if (offer.CreatedBy.Email != email && !isAdmin)
            {
                return;
            }

            _context.RemoveRange(offer.Images);
            _context.Remove(offer);

            await _context.SaveChangesAsync();
        }
    }
}

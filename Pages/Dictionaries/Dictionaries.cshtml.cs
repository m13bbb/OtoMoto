using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OtoMoto.Database;
using OtoMoto.Models;
using OtoMoto.Models.Input;

namespace OtoMoto.Pages.Dictionaries
{
    [Authorize(Consts.RequireAdminRole)]
    public class DictionariesModel : PageModel
    {
        private readonly Context _context;

        public DictionariesModel(Context context)
        {
            _context = context;
        }

        public List<TypPaliwa> TypyPaliwa { get; private set; } = new List<TypPaliwa>();

        public List<NadwoziePojazdu> TypyNadwozia { get; private set; } = new List<NadwoziePojazdu>();

        public async Task OnGet()
        {
            TypyPaliwa = await _context.TypyPaliwa.ToListAsync();
            TypyNadwozia = await _context.TypyNadwozia.ToListAsync();
        }

        public async Task<IActionResult> OnPostPaliwo(DictionaryEntry data)
        {
            if (data != null && !string.IsNullOrEmpty(data.Nazwa))
            {
                _context.TypyPaliwa.Add(new TypPaliwa { Nazwa = data.Nazwa });
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("Dictionaries");
        }

        public async Task<IActionResult> OnPostNadwozie(DictionaryEntry data)
        {
            if (data != null && !string.IsNullOrEmpty(data.Nazwa))
            {
                _context.TypyNadwozia.Add(new NadwoziePojazdu { Nazwa = data.Nazwa });
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("Dictionaries");
        }
        public async Task<IActionResult> OnGetDelete1(int Id)
        {
            var toDelete = await _context.TypyPaliwa.FirstOrDefaultAsync(x => x.Id == Id);
            _context.Remove(toDelete);
            await _context.SaveChangesAsync();
            return RedirectToPage("Dictionaries");
        }
        public async Task<IActionResult> OnGetDelete2(int Id)
        {
            var toDelete = await _context.TypyNadwozia.FirstOrDefaultAsync(x => x.Id == Id);
            _context.Remove(toDelete);
            await _context.SaveChangesAsync();
            return RedirectToPage("Dictionaries");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OtoMoto.Models
{
    public class Offer
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Kontakt { get; set; }

        public List<Image> Images { get; set; } = new List<Image>();

        public int Rocznik { get; set; }

        public int Przebieg { get; set; }

        public int Cena { get; set; }

        public TypPaliwa TypPaliwa { get; set; }

        public NadwoziePojazdu NadwoziePojazdu { get; set; }

        public DateTime DataUtworzenia { get; set; } = DateTime.Now;

        public User CreatedBy { get; set; }


    }
}

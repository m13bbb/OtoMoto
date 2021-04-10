using System;
using System.Collections.Generic;

namespace OtoMoto.Models.Input
{
    public class CreateOffer
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Kontakt { get; set; }

        public List<Guid> Images { get; set; } = new List<Guid>();

        public int Rocznik { get; set; }

        public int Przebieg { get; set; }

        public int Cena { get; set; }

        public int TypPaliwaId { get; set; }

        public int NadwoziePojazduId { get; set; }
    }
}

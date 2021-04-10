using System;

namespace OtoMoto.Models
{
    public class Image
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string FileName { get; set; }
    }
}
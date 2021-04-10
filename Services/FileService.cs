using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using OtoMoto.Database;
using OtoMoto.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace OtoMoto.Services
{
    public class FileService
    {
        private readonly Context _context;
        private readonly Settings _settings;

        public FileService(Context context, IOptions<Settings> Settings)
        {
            _context = context;
            _settings = Settings.Value;
        }

        public async Task<byte[]> GetImage(Guid Id)
        {
            var image = await _context.Images.FirstOrDefaultAsync(x => x.Id == Id);
            var path = Path.Combine(_settings.ImageContainerPath, image.FileName);

            if (!File.Exists(path))
            {
                return Array.Empty<byte>();
            }

            var bytes = await File.ReadAllBytesAsync(path);
            return bytes;
        }

        public async Task<Guid> SaveImage(IFormFile image)
        {
            var img = new Image
            {
                FileName = Guid.NewGuid().ToString("N")
            };

            if (!Directory.Exists(_settings.ImageContainerPath))
            {
                Directory.CreateDirectory(_settings.ImageContainerPath);
            }

            var path = Path.Combine(_settings.ImageContainerPath, img.FileName);

            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await image.CopyToAsync(fileStream);
            }

            await _context.AddAsync(img);
            await _context.SaveChangesAsync();

            return img.Id;
        }
    }
}

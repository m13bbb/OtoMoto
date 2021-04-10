using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OtoMoto.Services;
using System;
using System.Net.Mime;
using System.Threading.Tasks;

namespace OtoMoto.Controllers
{
    public class FileController : Controller
    {
        private readonly FileService _fs;

        public FileController(FileService fs)
        {
            _fs = fs;
        }

        [HttpGet("/Files/{Id}")]
        public async Task<IActionResult> GetFile(Guid Id)
        {
            var bytes = await _fs.GetImage(Id);
            return File(bytes, MediaTypeNames.Image.Jpeg);
        }    
        
        [Authorize]
        [HttpPost("/UploadImage")]
        public async Task<IActionResult> GetFile(IFormFile Image)
        {
            var guid = await _fs.SaveImage(Image);
            return Ok(guid);
        }
    }
}

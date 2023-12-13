using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using portafolio_api.NETCore6.Connection;
using portafolio_api.NETCore6.Models;

namespace portafolio_api.NETCore6.Controllers
{
    [Route("file")]
    [ApiController]
    public class FileController : ControllerBase
    {

        public static IWebHostEnvironment _webHostEnvironment;

        public FileController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult?> GetFile(string fileName)
        {
            string path = _webHostEnvironment.WebRootPath + "\\img\\";
            //var filePath = Path.Combine(path, fileName);
            var filePath = path + fileName;

            if (System.IO.File.Exists(filePath))
            {
                byte[] b = System.IO.File.ReadAllBytes(filePath);

                return File(b, "image/jpg");
            }

            return null;
        }

        [ApiKeyAuth]
        [HttpPost]
        [Route("")] 
        public async Task<string> SetFile([FromForm] FileUpload fileUpload)
        {
            try
            {
                if (fileUpload.Files.Length > 0)
                {
                    string path = _webHostEnvironment.WebRootPath + "\\chrono_cross\\";

                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    using (FileStream fileStream = System.IO.File.Create(path + fileUpload.Files.FileName))
                    {
                        fileUpload.Files.CopyTo(fileStream);
                        fileStream.Flush();

                        return "UPLOAD OK";
                    }
                }
                else
                {
                    return "Failed";
                }
            } 
             catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}

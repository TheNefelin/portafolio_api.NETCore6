using System.ComponentModel.DataAnnotations;

namespace portafolio_api.NETCore6.Models
{
    public class FileUpload
    {
        [Required]
        public IFormFile? Files { get; set; }
    }
}

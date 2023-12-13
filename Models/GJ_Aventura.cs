using System.ComponentModel.DataAnnotations;

namespace portafolio_api.NETCore6.Models
{
    public class GJ_AventuraGuia
    {
        [Required]
        [StringLength(50, ErrorMessage = "The Text Cannot Exceed the 50 Characters")]
        [EmailAddress]
        public string? Usuario { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "The Text Cannot Exceed the 255 Characters")]
        public string? Token { get; set; }
    }
}

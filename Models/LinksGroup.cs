using System.ComponentModel.DataAnnotations;

namespace portafolio_api.NETCore6.Models
{
    public class LinksGroup
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The Text Cannot Exceed the 50 Characters")]
        public string? Nombre { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The Text Cannot Exceed the 50 Characters")]
        public string? Orden { get; set; }

        [Required]
        public bool Estado { get; set; }
    }
}

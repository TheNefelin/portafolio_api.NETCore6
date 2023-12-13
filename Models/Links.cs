using System.ComponentModel.DataAnnotations;

namespace portafolio_api.NETCore6.Models
{
    public class Links
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The Text Cannot Exceed the 50 Characters")]
        public string? Nombre { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "The Text Cannot Exceed the 255 Characters")]
        public string? link { get; set; }

        [Required]
        public bool Estado { get; set; }

        [Required]
        public int Id_link_grp { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using static portafolio_api.NETCore6.Connection.ConexionBDContext;

namespace portafolio_api.NETCore6.Models
{
    public class LinksGroup
    {
        internal int id;

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The Text Cannot Exceed the 50 Characters")]
        public string? Nombre { get; set; }

        [Required]
        public bool Estado { get; set; }

        [Required]
        public List<Links> Links { get; set; } = new List<Links>();
    }
}

using System.ComponentModel.DataAnnotations;

namespace portafolio_api.NETCore6.Models
{
    public class DemoItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The Text Cannot Exceed the 50 Characters")]
        public string? Nombre { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The Text Cannot Exceed the 500 Characters")]
        public string? Descripcion { get; set; }

        [Required]
        public int Precio { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The Text Cannot Exceed the 255 Characters")]
        public string? Link { get; set; }

        [Required]
        public int Id_ItemCateg { get; set; }

        [Required]
        public bool IsActivo { get; set; }

        [Required]
        public int Id_Negocio { get; set; }
    }
}

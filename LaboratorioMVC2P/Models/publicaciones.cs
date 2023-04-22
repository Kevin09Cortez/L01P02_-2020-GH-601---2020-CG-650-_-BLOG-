using System.ComponentModel.DataAnnotations;

namespace LaboratorioMVC2P.Models
{
    public class publicaciones
    {
        [Key]
        [Display(Name = "ID")]
        public int publicacionId { get; set; }
        [Display(Name = "Título")]
        public string titulo { get; set; }
        [Display(Name = "Descripción")]
        public string descripcion { get; set; }
        [Display(Name = "Id de Usuario")]
        public int usuarioId { get; set; }
    }
}

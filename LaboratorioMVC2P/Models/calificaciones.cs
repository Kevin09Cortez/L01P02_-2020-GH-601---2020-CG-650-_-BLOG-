using System.ComponentModel.DataAnnotations;

namespace LaboratorioMVC2P.Models
{
    public class calificaciones
    {
        [Key]
        [Display(Name = "ID")]
        public int calificacionId { get; set; }
        [Display(Name = "Id de Publicación")]
        public int publicacionId { get; set; }
        [Display(Name = "Id de Usuario")]
        public int usuarioId { get; set; }
        [Display(Name = "Calificación")]
        public int calificacion { get; set; }

    }
}

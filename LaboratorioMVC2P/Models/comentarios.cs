using System.ComponentModel.DataAnnotations;

namespace LaboratorioMVC2P.Models
{
    public class comentarios
    {
        [Key]
        [Display(Name = "ID")]
        public int comentarioId { get; set; }
        [Display(Name = "Id de Publicación")]
        public int publicacionId { get; set; }
        [Display(Name = "Comentario")]
        public string? comentario { get; set; }
        [Display(Name = "Id de Usuario")]
        public int usuarioId { get; set; }
    }
}

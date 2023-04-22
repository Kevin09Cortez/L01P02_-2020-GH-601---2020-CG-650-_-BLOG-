using System.ComponentModel.DataAnnotations;

namespace LaboratorioMVC2P.Models
{
    public class usuarios
    {
        [Key]
        [Display(Name = "ID")]
        public int usuarioId { get; set; }
        [Display(Name = "Id de Rol")]
        public int rolId { get; set; }
        [Display(Name = "Nombre de Usuario")]
        public string nombreUsuario { get; set; }
        [Display(Name = "Clave")]
        public string clave { get; set; }
        [Display(Name = "Nombre")]
        public string nombre { get; set; }
        [Display(Name = "Apellido")]
        public string apellido { get; set; }
    }
}

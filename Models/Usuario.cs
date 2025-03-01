using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoProgramado_1.Models
{
    public class Usuario
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Nombre completo")]
        public string Nombre { get; set; }

        [DisplayName("Correo Electrónico")]
        [EmailAddress]
        public string Correo { get; set; }

        [Required]
        public int RolId { get; set; }

        // 🔴 Este constructor vacío es NECESARIO
        public Usuario() { }

        public Usuario(int id, string nombre, string correo, int rolId)
        {
            Id = id;
            Nombre = nombre;
            Correo = correo;
            RolId = rolId;
        }
    }
}



using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ProyectoProgramado_1.Models
{


    public class Rol
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Nombre del Rol")]
        public string Nombre { get; set; }

        public Rol(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }


    }
}
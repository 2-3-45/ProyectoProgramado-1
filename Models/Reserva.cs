using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoProgramado_1.Models
{
    public class Reserva
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [Required]
        public int ObraId { get; set; }

        [DisplayName("Fecha de Reserva")]
        public DateTime Fecha { get; set; }

        public Reserva(int id, int usuarioId, int obraId, DateTime fecha)
        {
            Id = id;
            UsuarioId = usuarioId;
            ObraId = obraId;
            Fecha = fecha;
        }
    }
}
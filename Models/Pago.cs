
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace ProyectoProgramado_1.Models
{
    public class Pago
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int ReservaId { get; set; }

        [DisplayName("Monto Total")]
        public decimal Monto { get; set; }

        [DisplayName("Método de Pago")]
        public string Metodo { get; set; }

        [DisplayName("Fecha de Pago")]
        public DateTime Fecha { get; set; }

        public Pago(int id, int reservaId, decimal monto, string metodo, DateTime fecha)
        {
            Id = id;
            ReservaId = reservaId;
            Monto = monto;
            Metodo = metodo;
            Fecha = fecha;
        }
    }

}

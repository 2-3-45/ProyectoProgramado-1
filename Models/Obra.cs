using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace ProyectoProgramado_1.Models
{


    public class Obra
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Título de la Obra")]
        public string Titulo { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        [Required]
        public int TeatroId { get; set; }





        // 🔴 Este constructor vacío es NECESARIO
        public Obra() { }

        public Obra(int id, string titulo, string descripcion, int teatroId)
        {
            Id = id;
            Titulo = titulo;
            Descripcion = descripcion;
            TeatroId = teatroId;
        }
    }

}
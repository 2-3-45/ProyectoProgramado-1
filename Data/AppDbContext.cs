
using Microsoft.EntityFrameworkCore;
using ProyectoProgramado_1.Models;


namespace ProyectoProgramado_1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ProyectoProgramado_1.Models.Usuario> Usuarios { get; set; } = default!;
        public DbSet<ProyectoProgramado_1.Models.Rol> Roles { get; set; } = default!;
        public DbSet<ProyectoProgramado_1.Models.Teatro> Teatros { get; set; } = default!;
        public DbSet<ProyectoProgramado_1.Models.Obra> Obras { get; set; } = default!;
        public DbSet<ProyectoProgramado_1.Models.Reserva> Reservas { get; set; } = default!;
        public DbSet<ProyectoProgramado_1.Models.Pago> Pagos { get; set; } = default!;
    }
}


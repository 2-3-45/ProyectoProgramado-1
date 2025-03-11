using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoProgramado_1.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class AdministradorDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Reportes()
        {
            return View();
        }

        public IActionResult Configuracion()
        {
            return View();
        }

        public IActionResult GestionUsuarios()
        {
            return RedirectToAction("Index", "Usuarios");
        }

        public IActionResult CerrarSesion()
        {
            return RedirectToAction("Logout", "Usuarios");
        }
    }
}

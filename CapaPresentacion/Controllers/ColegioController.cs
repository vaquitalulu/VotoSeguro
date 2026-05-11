using CapaEntidad;
using CapaNegocio;
using Microsoft.AspNetCore.Mvc;

namespace CapaPresentacion.Controllers
{
    public class ColegioController : Controller
    {
        // GET: /Colegio/Index
        public IActionResult Index()
        {
            ColegioNegocio cn = new ColegioNegocio();
            List<Colegio> lista = cn.Listar();
            return View(lista);
        }

        // POST: cuando el estudiante selecciona un colegio
        [HttpPost]
        public IActionResult Seleccionar(int idColegio, string nombreColegio)
        {
            // Guardamos el colegio en TempData para usarlo en el Login
            TempData["IdColegio"] = idColegio;
            TempData["NombreColegio"] = nombreColegio;

            // Redirigimos al Login
            return RedirectToAction("Index", "Login");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;
        private readonly IServicioEmail servicioemail;

        public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyecto,IServicioEmail servicioemail)
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyecto;
            this.servicioemail = servicioemail;
        }

        
        public IActionResult Index()

        {
            

            var modelo = new HomeIndexViewModel()
            {
                Proyectos = repositorioProyectos.ObtenerProyecto().Take(3).ToList(),
                
            };
            
            return View(modelo);
            
            //ViewBag.Nombre = "Enrique Terrero";
           
            return View();
        }

        public IActionResult Proyectos()
        {
            var proyectos = repositorioProyectos.ObtenerProyecto();

            return View(proyectos);
        }

   
        public IActionResult Contacto()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Contacto (ContactoViewModel contactoViewModel)
        {
            await servicioemail.Enviar(contactoViewModel);
            return RedirectToAction("Gracias");
        }
        public IActionResult Gracias()
        {
            return View();
        }
    }
}
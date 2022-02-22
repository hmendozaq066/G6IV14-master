using G6IV14.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace G6IV14.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }

        public IActionResult Gracias(string correo, string contrasena)
        {
            ViewBag.Correo = correo;
            ViewBag.Contrasena = contrasena;
            return View();
        }

        /* Cuando una acción (método) tiene parámetros estos pueden ser
         * enviados por GET o POST, en el caso del siguiente ejemplo
          la sintaxis del URL es: http://localhost:7396/Home/Saludo?Nombre=Pedrito&Edad=654654654 
        */
        public IActionResult Saludo(string Nombre, int Edad)
        {
            /* ViewBag es un diccionario de tipado débil para 
             * almacenar objetos de diferentes tipos */
            //Sintaxis ViewBag.NombreObjeto = Valor;
            ViewBag.Nombre = Nombre;
            ViewBag.Edad = Edad;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Listado.Models;
using System.Collections.Generic;

namespace Listado.Controllers
{
    public class ActividadController : Controller
    {
        //Declarando una instancia nueva que almacena objetos de tipo Actividad
        //Es una lista privada y estatica
        private static List<Actividad> _actividades = new List<Actividad>();
        public IActionResult Index()
        {
            //Para poder pasar un objeto del controlador a la vista se tiene
            //que usar el ViewBag
            ViewBag.Actividades = _actividades;
            return View();
        }

        public IActionResult Agregar()
        {
            return View();
        }
    }
}

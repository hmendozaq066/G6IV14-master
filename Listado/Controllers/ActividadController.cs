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

        //Aquí se indica que el siguiente método es llamado cuando
        //la página envía los datos por POST, sino se indica el método
        //es GET
        [HttpPost]
        public IActionResult Agregar(int ID, 
            string Descripcion, int Estado, int Prioridad)
        {
            //Declarando una instancia de tipo Actividad que se llama item
            var item = new Actividad();
            item.ID = ID;
            item.Descripcion = Descripcion;
            item.Estado = Estado;
            item.Prioridad = Prioridad;
            _actividades.Add(item);
            return RedirectToAction("Index");
        }
    }
}

﻿//Si no hay un using predeterminado, se debe agregar el System
using System;

namespace Listado.Models
{
    public class Actividad
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }
    }
}

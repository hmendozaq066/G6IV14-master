//Si no hay un using predeterminado, se debe agregar el System
using System;

namespace Listado.Models
{
    public class Actividad
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }

        public int Prioridad { get; set; }// 1 Normal 2 Media 3 Urgente

        public string GetEstado()
        {
            switch (Estado)
            {
                case 1:
                    return "Activo";
                case 2:
                    return "Completo";
                default:
                    return "Cancelado";
            }
        }

        public string GetPrioridad()
        {
            switch (Prioridad)
            {
                case 1:
                    return "Normal";
                case 2:
                    return "Medio";
                default:
                    return "Urgente";
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGYM_
{
    public class Suscripcion
    {
        public int Id { get; set; }
        public string Nombre { get; set; } 
        public decimal Precio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Estado estado { get; set; }
        public enum Estado { Activa, Inactiva, Suspendida }
    }
}

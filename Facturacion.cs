using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGYM_
{
    public class Facturacion
    {
        public int Id { get; set; }
        public Alumno alumno { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Descripcion { get; set; }
        public Suscripcion suscripcion { get; set; }
        public decimal Total { get; set; }
    }
}

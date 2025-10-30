using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGYM_
{
    public class Profesor: Usuario
    {
        public List <Actividad> actividad { get; set; }
        public List <Alimentacion> Alimentacion { get; set; }
        public List <Anuncios> Anuncios { get; set; }
        public string Descripcion { get; set; } 
    }
}

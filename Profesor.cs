using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGYM_
{
    public class Profesor: Usuario
    {
        public Actividad actividad { get; set; }
        public string Descripcion { get; set; } 
    }
}

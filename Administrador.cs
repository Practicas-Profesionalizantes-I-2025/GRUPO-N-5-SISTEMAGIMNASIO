using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGYM_
{
    public class Administrador: Usuario
    {
        public Permisos PermisosAdmin { get; set; }
        public enum Permisos { Lectura, Escritura, }
        
    }
}

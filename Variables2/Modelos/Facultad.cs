using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables2.Modelos
{
    public class Facultad
    {
        public String Nombre;
        public String Codiigo;
        public String MostrarDatos()
        {
            return "Facultad: " + Nombre + "- Codigo: " + Codiigo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Entidades
{
    public class Tripulante
    {
        public int legajo { get; set; }
        public int jefe { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int cod_puesto { get; set; }
        public int usuario { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Entidades
{
    class Pasajero
    {
        public int tipo_doc { get; set; }
        public int nro_doc { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int ciudad_procedente { get; set; }
        public int pais_procedente { get; set; }
        public string email { get; set; }
        public DateTime fechaNac { get; set; }
        public int genero { get; set; }
     
    }
}

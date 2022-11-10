using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Entidades
{
    public class Itinerario
    {
        public int Cod_Itinerario { get; set; }
        public string Descripcion { get; set; }
        public int Categoria { get; set; }
        public int NumEscala { get; set; }
        public string NomPais { get; set; }
        public string NomPuerto { get; set; }
    }   
}

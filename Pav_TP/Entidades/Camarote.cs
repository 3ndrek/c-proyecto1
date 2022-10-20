using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Entidades
{
    public class Camarote
    {
        public int cod_navio { get; set; }
        public int num_cubierta { get; set; }
        public int num_camarote { get; set; }
        public int tipo { get; set; }
        public int cant_camas { get; set; }


        // ver si es valido registrar un camarote con estos nuevos atributos 
        public string ocupacion { get; set; }

        public string cubierta_desc { get; set; }
        public string tipo_desc { get; set; } 

        // hay que agregarlo en la abm 
        public int monto { get; set; } 
        public void ValidarNavio()
        {
            if (string.IsNullOrEmpty(this.cod_navio.ToString()) && this.cod_navio < 0) {
                crearException("Debe ingresar un valor en el campo navio");
            }
        }

        public void ValidarCubierta()
        {
            if (string.IsNullOrEmpty(this.num_cubierta.ToString()) && this.num_cubierta < 0)
            {
                crearException("Debe ingresar un valor en el campo cubierta");
            }
        }

        public void ValidarNro()
        {
            if (string.IsNullOrEmpty(this.num_camarote.ToString()) && this.num_camarote < 0)
            {
                crearException("Debe ingresar un valor en el campo numero camarote");
            }
        }

        public ApplicationException crearException(string mensaje)
        {
            return new ApplicationException(mensaje);
        }

    }
}

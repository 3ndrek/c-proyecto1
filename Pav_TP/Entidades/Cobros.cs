using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Entidades
{
    public class Cobros
    {

        public int nro_reserva { get; set; }
        public int modo_pago { get; set; }
        public int monto { get; set; }

        public DateTime fecha_pago { get; set; }


    }
}

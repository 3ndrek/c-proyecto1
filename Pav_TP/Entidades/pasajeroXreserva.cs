using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Entidades
{
    public class pasajeroXreserva
    {
        public Cobros cobros { get; set;  }

        public int tipo_doc { get; set; }

        public int num_doc { get; set; } 
        public string estado_reserva { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Entidades
{
    public class Reservaciones
    {
        public int cod_navio { get; set;  }
        public int num_cubierta { get; set;  }
        public int num_camarote { get; set;  }
        public int cama_ocupada { get; set;  }
        public int tipo_doc { get; set;  }
        public int num_doc { get; set;  }
        public int num_reservacion { get; set;  }
        public DateTime fecha_viaje { get; set;  }

        public string estado_reserva { get; set; }

    }
}

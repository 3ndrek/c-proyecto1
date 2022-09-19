using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Entidades
{
    public class Cubierta
    {
        public int cod_navio { get; set;  }
        public int num_cubierta { get; set; }

        public string desc { get; set; }

        public int leg_encargado { get; set; }
    }
}

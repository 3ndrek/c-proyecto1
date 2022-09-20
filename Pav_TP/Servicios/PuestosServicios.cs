using Pav_TP.Entidades;
using Pav_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Servicios
{
    public class PuestosServicios
    {
        private PuestosRepositorio puestosRepositorio;

        public PuestosServicios()
        {
            puestosRepositorio = new PuestosRepositorio();
        }

        public List<Puestos> GetPuestos()
        {
            return puestosRepositorio.GetPuestos();
        }
    }
}

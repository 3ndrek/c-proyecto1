using Pav_TP.Entidades;
using Pav_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Servicios
{
    public class JefeServicios
    {
        private JefeRepositorio jefesRepositorio;

        public JefeServicios()
        {
            jefesRepositorio = new JefeRepositorio();
        }

        public List<Tripulante> GetJefes()
        {
            return jefesRepositorio.GetJefes();
        }
    }
}

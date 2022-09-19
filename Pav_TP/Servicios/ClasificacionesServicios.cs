using Pav_TP.Entidades;
using Pav_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Servicios
{
    public class ClasificacionesServicios
    {
        private ClasificacionesRepositorio clasificacionesRepositorio;

        public ClasificacionesServicios()
        {
            clasificacionesRepositorio = new ClasificacionesRepositorio();
        }

        public List<Clasificacion> GetClasificaciones()
        {
            return clasificacionesRepositorio.GetClasificaciones();
        }
    }
}

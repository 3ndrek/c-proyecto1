using Pav_TP.Entidades;
using Pav_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Servicios
{
    public class ReservacionesServicios
    {
        private static ReservacionesRepositorio itinerarios;

        public ReservacionesServicios()
        {
            itinerarios = new ReservacionesRepositorio();
        }

        public List<Itinerario> getItinerarios()
        {
            return itinerarios.GetItinerarios();
        }
    }
}

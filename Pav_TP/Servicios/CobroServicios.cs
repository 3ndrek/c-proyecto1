using Pav_TP.Entidades;
using Pav_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Servicios
{
    public class CobroServicios
    {
        private readonly CobroRepositorio cobroRepositorio;

        public CobroServicios ()
        {
            cobroRepositorio = new CobroRepositorio ();
        }

        public List<Reservaciones> GetReservaciones()
        {
            return cobroRepositorio.Getreservaciones();
        }



    }
}

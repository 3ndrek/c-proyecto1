using Pav_TP.Entidades;
using Pav_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Data;
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

        public List<Reservaciones> GetReservaciones(Pasajero pasajeroFiltro)
        {
            var list = new List<Reservaciones> ();
            var lista = new List<Reservaciones> ();
            list = cobroRepositorio.Getreservaciones();


            // ver que devuelve el array desde bd 
            foreach (Reservaciones reservacion  in list)
            {
                
                reservacion.estado_reserva = "n";
                lista.Add(reservacion);

            }
            return lista;
        }

        public List<Modo_pago> GetModos()
        {
            return cobroRepositorio.GetModo_Pagos();
        }

        public List<tiposDoc> GetTipos()
        {
            return cobroRepositorio.GetTiposDocs();
        }

    }
}

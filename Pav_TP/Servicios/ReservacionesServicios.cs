using Pav_TP.Entidades;
using Pav_TP.InterfacesDeUsuario.Transacciones;
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
        private static ReservacionesRepositorio reservacionesRepositorio;
        private static CamaroteRepositorio camarotess;

        public static Boolean ConfirmacionCargaTicket;

        public ReservacionesServicios()
        {
            reservacionesRepositorio = new ReservacionesRepositorio();
            camarotess = new CamaroteRepositorio();
            ConfirmacionCargaTicket = new Boolean();
        }

        public List<Entidades.Itinerario> getItinerarios()
        {
            return reservacionesRepositorio.GetItinerarios();
        }

        public List<Camarote> ObtenerCamarotes(int navio, int camas)
        {
            var listaBDCamarotes = camarotess.ObtenerCamarotes(navio, camas);
            var lista = new List<Camarote>();

            foreach (Camarote camarote in listaBDCamarotes)
            {
                if (camarote.ocupacion != 1)
                {
                    lista.Add(camarote);
                }
            }

            return lista;
        }

        public void CargarReserva(Reservaciones r)
        {
            reservacionesRepositorio.CargarReserva(r);
        }

        public List<Reservaciones> GetReservaciones()
        {
            return reservacionesRepositorio.GetReservaciones();
        }

        public int GetNroReservacion(Reservaciones r)
        {
            return reservacionesRepositorio.NroReservacionBusq(r);

        }

        public string buscarMail(Pasajero pasajero)
        {
            return reservacionesRepositorio.BuscarEmail(pasajero);
        }


        public List<Reservaciones> GetReservaciones(Reservaciones reserva)
        {
            return reservacionesRepositorio.GetReservaciones(reserva);
        }

        public void EliminarReserva(int id,int num, DateTime fecha, int cubierta, int navio)
        {
           reservacionesRepositorio.EliminarReserva(id, num, fecha, cubierta, navio);
        }

        public void confirmReservaTicket (Boolean b )
        {
            ConfirmacionCargaTicket = b; 

        }

        public bool varConfirmarRetorno()
        {
            return ConfirmacionCargaTicket;
        }

    }
}

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
        public ReservacionesServicios()
        {
            reservacionesRepositorio = new ReservacionesRepositorio();
            camarotess = new CamaroteRepositorio();
        }

        public List<Entidades.Itinerario> getItinerarios()
        {
            return reservacionesRepositorio.GetItinerarios();
        }

        public List<Camarote> ObtenerCamarotes(int navio, int camas)
        {
            var listaBDCamarotes = camarotess.ObtenerCamarotes(navio,camas );
            var lista = new List<Camarote>();

            foreach (Camarote camarote in listaBDCamarotes)
            {
                if (camarote.ocupacion != "ocupado")
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

        public List<Reservaciones> GetReservaciones(Reservaciones reserva)
        {
            return reservacionesRepositorio.GetReservaciones(reserva);
        }

        public void EliminarReserva(int id,int num, DateTime fecha, int cubierta, int navio)
        {
           reservacionesRepositorio.EliminarReserva(id, num, fecha, cubierta, navio);
        }
    }
}

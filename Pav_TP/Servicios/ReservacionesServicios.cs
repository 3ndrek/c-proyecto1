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
        private static CamaroteRepositorio camarotess;
        public ReservacionesServicios()
        {
            itinerarios = new ReservacionesRepositorio();
            camarotess = new CamaroteRepositorio();
        }

        public List<Itinerario> getItinerarios()
        {
            return itinerarios.GetItinerarios();
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
    }
}

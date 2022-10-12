using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Entidades
{
    public class Viaje
    {
        public int Cod_navio { get; set; }
        public int Origen { get; set; }
        public int Destino { get; set; }
        public DateTime FechaSalida { get; set; }
        public int Itinerario { get; set; }
        public int Duracion { get; set; }

        public void ValidarCodigo()
        {
            if (Cod_navio == null)
                throw new ApplicationException("El codigo es requerido.");
        }
        public void ValidarOrigen()
        {
            if (Origen == null)
                throw new ApplicationException("El origen es requerido.");
        }
        public void ValidarDestino()
        {
            if (Destino == null )
                throw new ApplicationException("El destino es requerido.");
        }
        public void ValidarItininerario()
        {
            if (Itinerario == null)
                throw new ApplicationException("El itinerario es requerido.");
        }
        public void ValidarFecha()
        {
            if (FechaSalida == DateTime.MinValue)
                throw new ApplicationException("La fecha de salida es requerido.");
            FechaSalida = new DateTime(FechaSalida.Year, FechaSalida.Month, FechaSalida.Day);
            if (FechaSalida < DateTime.Today)
                throw new ApplicationException("La fecha no puede ser menor a la fecha actual");
        }
        public void ValidarDuracion()
        {
            if (Duracion == null)
                throw new ApplicationException("La duración es requerido.");
        }

    }
}

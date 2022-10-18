using Pav_TP.Entidades;
using Pav_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Servicios
{
    public class ViajesServicios
    {
        private readonly ViajesRepositorio repositorio;

        public ViajesServicios()
        {
            repositorio = new ViajesRepositorio();
        }

        public List<Viaje> GetViajes()
        {
            return repositorio.GetViajes();
        }

        public List<Viaje> GetViajes(Viaje viaje)
        {
            return repositorio.GetViajes(viaje);
        }

        public List<Itinerario> GetItinerarios()
        {
            return repositorio.GetItinerario();
        }

        public List<Barco> ObtenerBarco()
        {
            return repositorio.ObtenerBarcos();
        }

        public Viaje GetViajes(int id, DateTime fecha)
        {
            return repositorio.GetViajes(id, fecha);
        }

        public void ValidarViaje(Viaje viajes)
        {
            viajes.ValidarCodigo();
            viajes.ValidarDuracion();
            viajes.ValidarFecha();
            viajes.ValidarItininerario();
        }

        public bool RegistrarViaje(Viaje viajes)
        {
            var filasAfectadas = repositorio.RegistrarViaje(viajes);
            if (filasAfectadas == 1)
                return true;

            return false;
        }

        public void ActualizarViaje(Viaje viaje)
        {
            var filasAfectadas = repositorio.ActualizarViaje(viaje);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }

        public void EliminarViaje(int id, DateTime fecha)
        {
            var filasAfectadas = repositorio.EliminarViaje(id, fecha);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }
    }
}


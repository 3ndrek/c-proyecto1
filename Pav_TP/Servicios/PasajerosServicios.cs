using Pav_TP.Entidades;
using Pav_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Servicios
{
    public class PasajerosServicios
    {
        private PasajerosRepositorio pasajerosRepositorio;

        public PasajerosServicios()
        {
            pasajerosRepositorio = new PasajerosRepositorio();
        }

        public List<Pasajero> GetPasajeros()
        {
            return pasajerosRepositorio.GetPasajeros();
        }

        public List<Pasajero> GetPasajeros(Pasajero p)
        {
            return pasajerosRepositorio.GetPasajeros(p);
        }

        public Pasajero GetPasajeros(int tipo, int id)
        {
            return pasajerosRepositorio.GetPasajeros(tipo, id);
        }

        public void ValidarPasajeros(Pasajero p)
        {
            p.ValidarTipoDoc();
            p.ValidarNumDoc();
            p.ValidarNombre();
            p.ValidarApellido();
            p.ValidarCiudad();
            p.ValidarPais();
            p.ValidarEmail();
            p.ValidarGenero();

        }
        public bool RegistrarPasajero(Pasajero p)
        {
            var filasAfectadas = pasajerosRepositorio.RegistrarPasajero(p);
            if (filasAfectadas == 1)
                return true;

            return false;
        }

        public void ActualizarPasajero(Pasajero p)
        {
            var filasAfectadas = pasajerosRepositorio.ActualizarPasajero(p);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }

        public void EliminarPasajero(int tipo, int id)
        {
            var filasAfectadas = pasajerosRepositorio.EliminarPasajero(tipo,id);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }
    }
}

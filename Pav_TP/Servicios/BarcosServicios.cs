using Pav_TP.Entidades;
using Pav_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Servicios
{
    public class BarcosServicios
    {
        private BarcosRepositorio barcosRepositorio;

        public BarcosServicios()
        {
            barcosRepositorio = new BarcosRepositorio();
        }

        public List<Barco> GetBarcos()
        {
            return barcosRepositorio.GetBarcos();
        }

        public List<Barco> GetBarcos(Barco barco)
        {
            return barcosRepositorio.GetBarcos(barco);
        }

        public Barco GetBarcos(int id)
        {
            return barcosRepositorio.GetBarcos(id);
        }

        public void ValidarBarco(Barco barco)
        {
            barco.ValidarNombre();
            barco.ValidarAltura();
            barco.ValidarManga();
            barco.ValidarDesplazamiento();
            barco.ValidarAutonomia();
            barco.ValidarCamarotes();
            barco.ValidarPasajeros();
            barco.ValidarMotores();
            barco.ValidarTripulacion();
            barco.ValidarClasificacion();
        }

        public bool RegistrarBarco(Barco barco)
        {
            var filasAfectadas = barcosRepositorio.RegistrarBarco(barco);
            if (filasAfectadas == 1)
                return true;

            return false;
        }

        public void ActualizarBarco(Barco barco)
        {
            var filasAfectadas = barcosRepositorio.ActualizarBarco(barco);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }

        public void EliminarBarco(int id)
        {
            var filasAfectadas = barcosRepositorio.EliminarBarco(id);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }
    }
}

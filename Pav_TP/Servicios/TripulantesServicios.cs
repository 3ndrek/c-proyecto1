using Pav_TP.Entidades;
using Pav_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pav_TP.Servicios
{
    public class TripulantesServicios
    {
        private TripulantesRepositorio tripulanteRepositorio;

        public TripulantesServicios()
        {
            tripulanteRepositorio = new TripulantesRepositorio();
        }

        public List<Tripulante> GetTripulantes()
        {
            return tripulanteRepositorio.GetTripulantes();
        }

        public List<Tripulante> GetTripulantes(Tripulante tripulante)
        {
            return tripulanteRepositorio.GetTripulantes(tripulante);
        }

        public Tripulante GetTripulantes(int id)
        {
            return tripulanteRepositorio.GetTripulantes(id);
        }

        public void ValidarTripulante(Tripulante tripulante)
        {
            tripulante.ValidarJefe();
            tripulante.ValidarNombre();
            tripulante.ValidarApellido();
            tripulante.ValidarEmail();
            tripulante.ValidarPuesto();
           
        }

        public bool RegistrarTripulante(Tripulante t)
        {
            var filasAfectadas = tripulanteRepositorio.RegistrarTripulantet(t);
            if (filasAfectadas == 1)
                return true;

            return false;
        }

        public void ActualizarTripulante(Tripulante t)
        {
            var filasAfectadas = tripulanteRepositorio.ActualizarTripulante(t);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }

        public void EliminarTripulante(int id)
        {
            var filasAfectadas = tripulanteRepositorio.EliminarTripulante(id);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }
    }
}

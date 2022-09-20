using Pav_TP.Entidades;
using Pav_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Servicios
{
    public class CiudadServicios
    {
        private CiudadesRepositorio ciudadRepositorio;

        public CiudadServicios()
        {
            ciudadRepositorio = new CiudadesRepositorio();
        }

        public List<Ciudad> GetCiudades()
        {
            return ciudadRepositorio.GetCiudades();
        }
    }
}

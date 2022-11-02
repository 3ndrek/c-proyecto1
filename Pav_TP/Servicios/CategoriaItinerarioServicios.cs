using Pav_TP.Entidades;
using Pav_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Servicios
{
    public class CategoriaItinerarioServicios
    {
        private CategoriaItinerarioRepositorio categoriaItinerarioRepositorio;

        public CategoriaItinerarioServicios()
        {
            categoriaItinerarioRepositorio = new CategoriaItinerarioRepositorio();
        }

        public List<CategoriasItinerarios> GetCategoriasItinerarios()
        {
            return categoriaItinerarioRepositorio.GetCategorias();
        }
    }
}

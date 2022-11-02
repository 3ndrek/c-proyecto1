using Pav_TP.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Repositorios
{
    public class CategoriaItinerarioRepositorio
    {
        public List<CategoriasItinerarios> GetCategorias()
        {
            var categorias = new List<CategoriasItinerarios>();
            var sentenciaSql = $"SELECT * FROM categoriasItinerarios";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var categoria = new CategoriasItinerarios();
                categoria.categoria= Convert.ToInt32(fila["categoria"]);
                categoria.descripcion = fila["descripcion"].ToString();
                categoria.precio_base = Convert.ToInt32(fila["precio_base"]);

                categorias.Add(categoria);
            }

            return categorias;
        }
    }
}

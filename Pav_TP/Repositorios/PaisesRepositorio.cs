using System.Data;
using Pav_TP.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Repositorios
{
    public class PaisesRepositorio
    {
        public List<Paises> GetPaises()
        {
            var paises = new List<Paises>();
            var sentenciaSql = $"SELECT * FROM paises";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var pais = new Paises();
                pais.cod_pais = Convert.ToInt32(fila["cod_pais"]);
                pais.nombre = fila["nombre"].ToString();

                paises.Add(pais);
            }

            return paises;
        }
    }
}

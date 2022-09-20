using Pav_TP.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Repositorios
{
    public class CiudadesRepositorio
    {
        public List<Ciudad> GetCiudades()
        {
            var ciudades = new List<Ciudad>();
            var sentenciaSql = $"SELECT * FROM ciudades";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var ciudad = new Ciudad();
                ciudad.cod_ciudad = Convert.ToInt32(fila["cod_ciudad"]);
                ciudad.nombre = fila["nombre"].ToString();

                ciudades.Add(ciudad);
            }

            return ciudades;
        }
    }
}

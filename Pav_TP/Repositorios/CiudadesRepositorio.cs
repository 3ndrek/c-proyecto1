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
        public List<Ciudad> GetCiudades(Paises pais)
        {
            var ciudades = new List<Ciudad>();
            var sentenciaSql = $"SELECT C.* FROM ciudades C JOIN paisesXciudades PxC ON C.cod_ciudad = PxC.cod_ciudad JOIN paises P ON Pxc.cod_pais = P.cod_pais WHERE P.cod_pais = {pais.cod_pais}";
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

using Pav_TP.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Repositorios
{
    public class ClasificacionesRepositorio
    {
        public List<Clasificacion> GetClasificaciones()
        {
            var clasificaciones = new List<Clasificacion>();
            var sentenciaSql = $"SELECT * FROM clasificacion_navios";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var clasificacion = new Clasificacion();
                clasificacion.Cod = Convert.ToInt32(fila["cod"]);
                clasificacion.Desc = fila["descripcion"].ToString();

                clasificaciones.Add(clasificacion);
            }

            return clasificaciones;
        }
    }
}

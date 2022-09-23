using Pav_TP.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Repositorios
{
    public class JefeRepositorio
    {
        public List<Tripulante> GetJefes()
        {
            var t = new List<Tripulante>();
            var sentenciaSql = $"SELECT * FROM tripulantes WHERE jefe = 0";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var tr = new Tripulante();
                tr.jefe= Convert.ToInt32(fila["jefe"]);
                tr.nombre = fila["nombre"].ToString();
                tr.apellido = fila["apellido"].ToString();
                tr.legajo = Convert.ToInt32(fila["legajo"].ToString());
               
                t.Add(tr);
            }

            return t;
        }
    }
}

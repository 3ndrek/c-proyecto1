using Pav_TP.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Repositorios
{
    public class PuestosRepositorio
    {
        public List<Puestos> GetPuestos()
        {
            var puestos = new List<Puestos>();
            var sentenciaSql = $"SELECT * FROM puestos";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var puesto = new Puestos();
                puesto.cod_puesto = Convert.ToInt32(fila["cod_puesto"]);
                puesto.desc = fila["desc"].ToString();

                puestos.Add(puesto);
            }

            return puestos;
        }

    }
}

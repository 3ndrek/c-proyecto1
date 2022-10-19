using Pav_TP.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Repositorios
{
    public class GeneroRepositorio
    {
        public List<Genero> GetGeneros()
        {
            var generos = new List<Genero>();
            var sentenciaSql = $"SELECT * FROM genero";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var genero = new Genero();
                genero.tipo = Convert.ToInt32(fila["tipo"]);
                genero.desc = fila["descripcion"].ToString();

                generos.Add(genero);
            }

            return generos;
        }
    }
}

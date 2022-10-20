using Pav_TP.Entidades;
using Pav_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Entidades
{
    public class TipoDocRepositorio
    {
        public List<TipoDoc> GetTipos()
        {
            var tipos = new List<TipoDoc>();
            var sentenciaSql = $"SELECT * FROM tipo_doc";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var tipo = new  TipoDoc();
                tipo.tipo = Convert.ToInt32(fila["tipo"]);
                tipo.desc = fila["descripcion"].ToString();

                tipos.Add(tipo);
            }

            return tipos;
        }
    }
}

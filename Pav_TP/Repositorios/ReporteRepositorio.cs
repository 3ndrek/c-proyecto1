using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Repositorios
{
    public class ReporteRepositorio
    {

        public DataTable ReporteReservas()
        {
            var sql = "SELECT r.fecha_viaje, r.cod_navio FROM reservaciones r ";
            var dataTable = DBHelper.GetDBHelper().ConsultaSQL(sql);
            return dataTable;
        }

    }
}

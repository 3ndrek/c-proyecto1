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
            var sql = "SELECT r.fecha_viaje, ci.descripcion, p.nombre " +
                "FROM reservaciones r JOIN viaje v ON r.cod_navio = v.cod_navio " +
                "AND r.fecha_viaje = v.fecha_viaje JOIN puertoXitinerarios pXi " +
                "ON v.cod_itinerario = pXi.cod_itinerarios JOIN puertosXpaises pXp " +
                "ON pXi.cod_puerto = pXp.cod_puerto JOIN paises p ON pXp.cod_pais = p.cod_pais " +
                "JOIN itinerarios i ON i.cod_itinerario = v.cod_itinerario " +
                "JOIN categoriasItinerarios ci ON ci.categoria = i.categoria " +
                "GROUP BY r.fecha_viaje, ci.descripcion, p.nombre";
            var dataTable = DBHelper.GetDBHelper().ConsultaSQL(sql);
            return dataTable;
        }

    }
}

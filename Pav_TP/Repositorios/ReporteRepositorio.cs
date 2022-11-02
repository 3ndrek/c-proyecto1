using Pav_TP.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public DataTable BugsPorFiltros(ReporteFiltros r)
        {
            var sql = $"SELECT r.fecha_viaje, ci.descripcion as categoria, p.nombre as puertoSalida FROM reservaciones r JOIN viaje v ON r.cod_navio = v.cod_navio AND r.fecha_viaje = v.fecha_viaje JOIN puertoXitinerarios pXi ON v.cod_itinerario = pXi.cod_itinerarios JOIN puertosXpaises pXp ON pXi.cod_puerto = pXp.cod_puerto" +
                      $" JOIN paises p ON pXp.cod_pais = p.cod_pais"+
                      $" JOIN itinerarios i ON i.cod_itinerario = v.cod_itinerario"+
                      $" JOIN categoriasItinerarios ci ON ci.categoria = i.categoria"+
                      $" WHERE 1 = 1";
            if (r.FechaDesde.HasValue)
                sql += $" AND r.fecha_viaje > '{r.FechaDesde.Value.ToString("yyyy-MM-dd")}'";
            if (r.FechaHasta.HasValue)
                sql += $" AND r.fecha_viaje < '{r.FechaHasta.Value.ToString("yyyy-MM-dd")}'";
            if (r.Categoria.HasValue && r.Categoria != 0)
                sql += $" AND ci.categoria ={r.Categoria}";
            sql += " GROUP BY r.fecha_viaje, ci.descripcion, p.nombre";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sql);
            return tabla;
        }


    }
}

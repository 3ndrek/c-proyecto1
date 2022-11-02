using Pav_TP.Entidades;
using Pav_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Servicios
{
    public class ReporteServicio
    {
        private readonly ReporteRepositorio respositorio;

        public ReporteServicio()
        {
            this.respositorio = new ReporteRepositorio();
        }

        public DataTable Reservas()
        {
            return respositorio.ReporteReservas();
        }

        public DataTable ReportePorFiltro(ReporteFiltros r)
        {
            return respositorio.BugsPorFiltros(r);
        }
    }
}

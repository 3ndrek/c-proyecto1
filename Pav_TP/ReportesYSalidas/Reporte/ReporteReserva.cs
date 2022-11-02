using Microsoft.Reporting.WinForms;
using Pav_TP.Entidades;
using Pav_TP.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pav_TP.ReportesYSalidas.Reporte
{
    public partial class ReporteReserva : Form
    {
        private readonly ReporteServicio reporteServicio;
        private readonly CategoriaItinerarioServicios categoriaServicios;
        public ReporteReserva()
        {
            reporteServicio = new ReporteServicio();
            categoriaServicios = new CategoriaItinerarioServicios();
            InitializeComponent();
        }

        private void ReporteReserva_Load(object sender, EventArgs e)
        {
            CargarCategoria();
            ObtenerReporte();
        }
        
        public void CargarCategoria()
        {
            var cat = categoriaServicios.GetCategoriasItinerarios();
            var catSeleccionar = new CategoriasItinerarios();
            catSeleccionar.descripcion = "Seleccionar";
            cat.Add(catSeleccionar);

            var conector = new BindingSource();
            conector.DataSource = cat;

            cmbCategoria.DataSource = conector;
            cmbCategoria.DisplayMember = "descripcion";
            cmbCategoria.ValueMember = "categoria";
            cmbCategoria.SelectedItem = catSeleccionar;
        }

        public void CargarReporte(ReporteFiltros filtros)
        {
            this.RwReserva.LocalReport.DataSources.Clear();
            var datos = reporteServicio.ReportePorFiltro(filtros);

            var datasource = new ReportDataSource("Grafico", datos);
            this.RwReserva.LocalReport.DataSources.Add(datasource);

            var hoy = DateTime.Now;
            var parametros = new List<ReportParameter>() {
                //new ReportParameter("AnioActual", hoy.Year.ToString()),
                new ReportParameter("FechaGeneracionReporte", hoy.ToString("dd/MM/yyyy hh:mm")),
                new ReportParameter("FechaDesde", filtros.FechaDesde?.ToString("dd/MM/yyyy")),
                new ReportParameter("FechaHasta", filtros.FechaHasta?.ToString("dd/MM/yyyy")),
                new ReportParameter("CategoriaItinerario",filtros.NomCategori)
            };

            this.RwReserva.LocalReport.SetParameters(parametros);
            this.RwReserva.RefreshReport();
        }

        public void ObtenerReporte()
        {
            var filtros = new ReporteFiltros();
            filtros.FechaDesde = dtpFechaDesde.Value;
            filtros.FechaHasta = dtpFechaHasta.Value;
            filtros.Categoria = (int)cmbCategoria.SelectedValue;
            var c = (CategoriasItinerarios)cmbCategoria.SelectedItem;
            var cat = filtros.Categoria != 0 ?
                c.descripcion : "TODAS";
            filtros.NomCategori = cat;
            CargarReporte(filtros);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ObtenerReporte();

        }
    }
}

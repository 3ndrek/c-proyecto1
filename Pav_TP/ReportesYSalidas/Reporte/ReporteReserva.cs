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
            this.reportViewer1.RefreshReport();
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
        
        public void ObtenerReporte()
        {
            var filtros =  new 
        }

    }
}

using Pav_TP.Servicios;
using seastar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pav_TP.InterfacesDeUsuario.Transacciones
{
    public partial class Itinerario : Form
    {
        private readonly ItinerarioServicios itinerarioServicios;
        private readonly FrmPrincipal frmPrincipal;

        public Itinerario(FrmPrincipal f)
        {
            frmPrincipal = f;
            itinerarioServicios = new ItinerarioServicios();
            InitializeComponent();
        }

        private void Itinerario_Load(object sender, EventArgs e)
        {
            itinerarioServicios.CargarPaises(cmbPais);
            itinerarioServicios.CargarCategorias(cmbCategoria);
            CargarDgv();
        }

        private void CargarPuertosXPais(int cod_pais)
        {
            var puertosXpaises = itinerarioServicios.GetPuertosXPais(cod_pais);
            var puertoDefault = new Pav_TP.Entidades.Puertos();
            puertoDefault.cod_puerto = 0;
            puertoDefault.nombre = "Seleccionar";

            var conector = new BindingSource();
            conector.DataSource = puertosXpaises;

            cmbPuerto.DataSource = conector;
            cmbPuerto.DisplayMember = "nombre";
            cmbPuerto.ValueMember = "nombre";
            cmbPuerto.SelectedItem = puertoDefault;

        }

        private void cmbPuerto_Click(object sender, EventArgs e)
        {
            CargarPuertosXPais(itinerarioServicios.GetCodPais(cmbPais.SelectedValue.ToString()));
        }

        private void CargarDgv()
        {
            dgvPuertos.ColumnCount = 3;
            dgvPuertos.Columns[0].Name = "Pais";
            dgvPuertos.Columns[1].Name = "Puertos";
            dgvPuertos.Columns[2].Name = "Nro Escala";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int n = itinerarioServicios.GenerarNroEscala(dgvPuertos);
            string[] row = { $"{cmbPais.SelectedValue}", $"{cmbPuerto.SelectedValue}", $"{n}" };

            dgvPuertos.Rows.Add(row);
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //int cod_i = itinerarioServicios.GenerarCodItinerario();
            string c =cmbCategoria.Text;
            DataGridViewRow d1 = dgvPuertos.Rows[0];
            DataGridViewRow d2 = dgvPuertos.Rows[dgvPuertos.RowCount-2];
            string primerP = d1.Cells[1].Value.ToString();
            string ultimoP = d2.Cells[1].Value.ToString();
            string nombreI = c + " - " + primerP + " - " + ultimoP;
            int cat = Convert.ToInt32(cmbCategoria.SelectedValue);
            itinerarioServicios.RegistrarItinerario(cat,nombreI);
            int cod_i = itinerarioServicios.ObtenerUltimoCodi();
            itinerarioServicios.RegistrarPuertosXItinerario(dgvPuertos, cod_i);
            MessageBox.Show($"El itinerario {nombreI} se registro con exito...");
        }

        private void CerrarFormulario()
        {
            frmPrincipal.Show();
            this.Dispose();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void Itinerario_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarFormulario();
        }
    }
}



using Pav_TP.Entidades;
using Pav_TP.Servicios;
using PAV1;
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

namespace Pav_TP.InterfacesDeUsuario.Barco
{
    public partial class ConsultarBarco : Form
    {
        private BarcosServicios barcosServicios;
        private FrmPrincipal frmPrincipal;
        public ConsultarBarco(FrmPrincipal frm)

        {
            frmPrincipal = frm;
            barcosServicios = new BarcosServicios();
            InitializeComponent();
        }

        private void ConsultarBarco_Load(object sender, EventArgs e)
        {
            CargarBarcos();
        }

        private void CargarBarcos()
        {
            var barcos = barcosServicios.GetBarcos();
            DgvBarco.Rows.Clear();
            FuncionalidadCargarBarcos(barcos);
        }
        private void CargarBarcos(Entidades.Barco bf)
        {
            var barcos = barcosServicios.GetBarcos(bf);
            DgvBarco.Rows.Clear();
            FuncionalidadCargarBarcos(barcos);
        }

        private void FuncionalidadCargarBarcos(List<Entidades.Barco> barcos)
        {
            foreach (var barco in barcos)
            {
                var fila = new string[]
                {
                    barco.Codigo.ToString(),
                    barco.Nombre.ToString(),
                    barco.Altura.ToString(),
                    barco.Eslora.ToString(),
                    barco.Manga.ToString(),
                    barco.Desplazamiento.ToString(),
                    barco.Autonomia.ToString(),
                    barco.CantCamarote.ToString(),
                    barco.CantMaxPasajeros.ToString(),
                    barco.CantMotores.ToString(),
                    barco.CantTripulante.ToString(),
                    barco.Clasificacion.ToString()
                };
                DgvBarco.Rows.Add(fila);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegistrarBarco(frmPrincipal).Show();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(DgvBarco.SelectedRows[0].Cells["Codigo"].Value);

            // this.Hide();
            new ModificarBarco(id).Show();
            DgvBarco.Rows.Clear();
            CargarBarcos();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(DgvBarco.SelectedRows[0].Cells["Codigo"].Value);
            barcosServicios.EliminarBarco(id);
            DgvBarco.Rows.Clear();
            CargarBarcos();
        }

        private void BtnFiltro_Click(object sender, EventArgs e)
        {
            var barcoFiltro = new Entidades.Barco();
            if (Convert.ToInt32(TxtFiltroCodigo.Text.Trim()) != 0)
                barcoFiltro.Codigo = Convert.ToInt32(TxtFiltroCodigo.Text.Trim());
            barcoFiltro.Nombre = TxtFiltroNombre.Text.Trim();
            if (Convert.ToInt32(TxtFiltroCodigo.Text.Trim()) != 0 || TxtFiltroNombre.Text.Trim() != null)
            {
                CargarBarcos(barcoFiltro);
                return;
            }
            CargarBarcos();

        }


        private void CerrarFormulario()
        {
            frmPrincipal.Show();
            this.Dispose();

        }

        private void ConsultarBarco_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarFormulario();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal.Show();
        }
    }
}

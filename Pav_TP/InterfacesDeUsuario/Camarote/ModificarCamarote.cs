using Pav_TP.Entidades;
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

namespace Pav_TP.InterfacesDeUsuario.Camarote
{
    public partial class ModificarCamarote : Form
    {
        private readonly CamaroteServicios camaroteServicio;
        //Cuando termines hace el FormClosing
        private readonly FrmPrincipal frmPrincipal;
        public ModificarCamarote(FrmPrincipal f)
        {
            camaroteServicio = new CamaroteServicios();
            frmPrincipal = f;
            InitializeComponent();
        }

        private void ModificarCamarote_Load(object sender, EventArgs e)
        {
            camaroteServicio.CargarBarcos(CmbNavio);

        }
        private void CargarCubierta(int b)
        {
            var cubiertasXBarco = camaroteServicio.GetCubiertas(b);
            var cubiertaDefault = new Cubierta();
            cubiertaDefault.cod_navio = 0;
            cubiertaDefault.num_cubierta = 0;

            var conector = new BindingSource();
            conector.DataSource = cubiertasXBarco;

            CmbCubierta.DataSource = conector;
            CmbCubierta.DisplayMember = "descripcion";
            CmbCubierta.ValueMember = "num_cubierta";
            CmbCubierta.SelectedItem = cubiertaDefault;
        }

        private void CargarNroCamarote(int b, int cub)
        {
            var camarotesXCubierta = camaroteServicio.GetCamarotes(Convert.ToInt32(CmbNavio.SelectedValue), Convert.ToInt32(CmbCubierta.SelectedValue));
            var camaroteDefault = new Pav_TP.Entidades.Camarote();
            camaroteDefault.cod_navio = 0;
            camaroteDefault.num_cubierta = 0;
            camaroteDefault.num_camarote = 0;

            var conector = new BindingSource();
            conector.DataSource = camarotesXCubierta;

            CmbNroCamarote.DataSource = conector;
            CmbNroCamarote.DisplayMember = "num_camarote";
            CmbNroCamarote.ValueMember = "num_camarote";
            CmbNroCamarote.SelectedItem = camaroteDefault;

        }

        private void CmbCubierta_Click(object sender, EventArgs e)
        {
            CargarCubierta(Convert.ToInt32(CmbNavio.SelectedValue));
        }

        private void CmbNroCamarote_Click(object sender, EventArgs e)
        {
            CargarNroCamarote(Convert.ToInt32(CmbNavio.SelectedValue), Convert.ToInt32(CmbCubierta.SelectedValue));
        }

        private void CmbTipo_Click(object sender, EventArgs e)
        {
            camaroteServicio.CargarTipoCamarote(CmbTipo);
        }

        private void CmbUbicacion_Click(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var camarote = new Pav_TP.Entidades.Camarote();
                camarote.cod_navio = Convert.ToInt32(CmbNavio.SelectedValue);
                camarote.num_cubierta = Convert.ToInt32(CmbCubierta.SelectedValue);
                camarote.num_camarote = Convert.ToInt32(CmbNroCamarote.SelectedValue);
                camarote.tipo = Convert.ToInt32(CmbTipo.SelectedValue);
                camarote.cant_camas = Convert.ToInt32(Txtcamas.Text);

                camaroteServicio.ModificarCamarote(camarote);
                MessageBox.Show("La modificacion se realizo con exito");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la modificacion");
            }
        }


        private void CerrarFormulario()
        {
            frmPrincipal.Show();
            this.Dispose();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void ModificarCamarote_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarFormulario();
        }
    }
}

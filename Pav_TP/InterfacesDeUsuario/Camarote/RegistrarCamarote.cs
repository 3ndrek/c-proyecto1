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
    public partial class RegistrarCamarote : Form
    {
        private readonly CamaroteServicios camaroteServicio;
        //Cuando termines hace el FormClosing
        private readonly FrmPrincipal frmPrincipal;
        
        public RegistrarCamarote()
        {
            camaroteServicio = new CamaroteServicios();
            InitializeComponent();
        }
        
        public RegistrarCamarote(FrmPrincipal f)
        {
            frmPrincipal = f;
            camaroteServicio = new CamaroteServicios(); 
            InitializeComponent();
        }

        private void RegistrarCamarote_Load(object sender, EventArgs e)
        {
            camaroteServicio.CargarBarcos(CmbNavio);
            camaroteServicio.CargarTipoCamarote(CmbTipoCam);
            camaroteServicio.CargarUbicaciones(CmbUbicacion);

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

        private void CmbCubierta_Click(object sender, EventArgs e)
        {
            CargarCubierta(Convert.ToInt32(CmbNavio.SelectedValue));
        }

        private void RegistrarCamarote1 (Pav_TP.Entidades.Camarote dato)
        {
            camaroteServicio.RegistrarCamarote(dato);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                var dato = new Pav_TP.Entidades.Camarote();
                dato.cod_navio = (int)CmbNavio.SelectedValue;
                dato.num_cubierta = (int)CmbCubierta.SelectedValue;
                dato.num_camarote = Convert.ToInt32(TxtNumCamarote.Text);
                dato.tipo = (int)CmbTipoCam.SelectedValue;
                dato.cant_camas = Convert.ToInt32(TxtCantCamas.Text);


                RegistrarCamarote1(dato);
                MessageBox.Show("Camarote cargado con exito", "Registrar camarote", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Registro invalido... Verifique los campos", "Error 404", MessageBoxButtons.OK);
            }

        }

        private void CerrarFormulario()
        {
            frmPrincipal.Show();
            this.Dispose();

        }
        private void CerrarFormularioOpcional()
        {
            this.Dispose();

        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (frmPrincipal != null)
                CerrarFormulario();
            else CerrarFormularioOpcional();
        }

        private void RegistrarCamarote_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmPrincipal != null)
                CerrarFormulario();
            else CerrarFormularioOpcional();
        }
    }
}

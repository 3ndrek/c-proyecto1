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

namespace PAV1
{
    public partial class RegistrarCubierta : Form
    {
        private readonly CubiertasServicio cubiertasServicio;
        private readonly FrmPrincipal frmPrincipal;

        public RegistrarCubierta(FrmPrincipal frmPrincipal1)
        {
            frmPrincipal = frmPrincipal1;
            InitializeComponent();
            cubiertasServicio = new CubiertasServicio(); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarBarco();
            GetTripulantes();
        }

        private void CargarBarco()
        {
            var barcos = cubiertasServicio.GetBarcos();
            var barcoDefault = new Barco();
            barcoDefault.Codigo = 0;
            barcos.Add(barcoDefault);

            var conector = new BindingSource();
            conector.DataSource = barcos;

            CmbCodNav.DataSource = conector;
            CmbCodNav.DisplayMember = "Nombre";
            CmbCodNav.ValueMember = "Codigo";
            CmbCodNav.SelectedItem = barcoDefault;

        }

        private void GetTripulantes()
        {
            var tripulantes = cubiertasServicio.GetTripulantes();
            var tripulanteDefault = new Tripulante();
            tripulanteDefault.legajo = 0;

            tripulantes.Add(tripulanteDefault);
            var conector = new BindingSource();
            conector.DataSource = tripulantes;

            CmbLegEnc.DataSource = conector;
            CmbLegEnc.DisplayMember = "legajo";
            CmbLegEnc.ValueMember = "legajo";
        }

        private void registrarCubierta(Cubierta dato)
        {
            cubiertasServicio.RegistrarCubierta(dato);
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            var dato = new Cubierta();
            dato.cod_navio = (int)CmbCodNav.SelectedValue;
            dato.leg_encargado = (int)CmbLegEnc.SelectedValue;
            dato.desc = TxtDesc.Text;
            registrarCubierta(dato);

            MessageBox.Show("cubierta cargada con Exito", "Registrar Cubierta", MessageBoxButtons.OK);
        }

        private void CerrarFormulario()
        {
            frmPrincipal.Show();
            this.Dispose();

        }

        private void RegistrarCubierta_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarFormulario();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }
    }
}

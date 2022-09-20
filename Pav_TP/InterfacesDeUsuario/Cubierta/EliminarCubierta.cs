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
    public partial class EliminarCubierta : Form
    {
        private readonly CubiertasServicio cubiertasSServicio;
        private readonly Menu menu;
        private readonly FrmPrincipal frmPrincipal;

        public EliminarCubierta(FrmPrincipal frmPrincipal1)
        {
            frmPrincipal = frmPrincipal1;
            cubiertasSServicio = new CubiertasServicio();
            InitializeComponent();
        }




        private void ConsultarCubiertas(Cubierta filtros)
        {
            var cubiertas = cubiertasSServicio.GetCubiertas(filtros);

            foreach (var cubierta in cubiertas)
            {
                LblDesc.Show();
                LblEncargado.Show();
                LblDesc.Text = cubierta.desc;
                LblEncargado.Text = cubierta.leg_encargado.ToString();

            }


        }


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var filtros = new Cubierta();
            filtros.cod_navio = (int)CmbCodNav.SelectedValue;
            filtros.num_cubierta = (int)CmbNumCub.SelectedValue;

            ConsultarCubiertas(filtros);

        }

        private void CmbCodNav_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCubiertas((Barco)CmbCodNav.SelectedItem);
        }


        private void CargarBarco()
        {
            var barcos = cubiertasSServicio.GetBarcos();
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

        private void CargarCubiertas(Barco barco)
        {

            var cubiertas = cubiertasSServicio.GetCubiertas(barco);
            var cubiertaDefault = new Cubierta();

            cubiertaDefault.num_cubierta = 0;
            cubiertas.Add(cubiertaDefault);

            var conector = new BindingSource();
            conector.DataSource = cubiertas;

            CmbNumCub.DataSource = conector;
            CmbNumCub.DisplayMember = "num_cubierta";
            CmbNumCub.ValueMember = "num_cubierta";
            CmbNumCub.SelectedItem = cubiertaDefault;



        }

        private void EliminarCubierta_Load(object sender, EventArgs e)
        {
            LblDesc.Hide();
            LblEncargado.Hide();
            CargarBarco();
        }


        private void Eliminar(Cubierta filtros)
        {
            cubiertasSServicio.EliminarCubierta(filtros);
        }

        private void BtnEliminarCubierta_Click(object sender, EventArgs e)
        {
            var filtros = new Cubierta();
            filtros.cod_navio = (int)CmbCodNav.SelectedValue;
            filtros.num_cubierta = (int)CmbNumCub.SelectedValue;

            Eliminar(filtros);

            MessageBox.Show("eliminar exitoso", "Eliminar", MessageBoxButtons.OK);

            LblDesc.Hide();
            LblEncargado.Hide();


        }
        private void CerrarFormulario()
        {
            frmPrincipal.Show();
            this.Dispose();

        }

        private void EliminarCubierta_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarFormulario();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }
    }
}




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

namespace PAV1
{
    public partial class ModificarCubierta : Form
    {
        private readonly CubiertasServicio cubiertasServicio;

        public ModificarCubierta()
        {
            cubiertasServicio = new CubiertasServicio();
            InitializeComponent();
        }

        private void ModificarCubierta_Load(object sender, EventArgs e)
        {
            CargarBarco();
            
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
        private void CargarCubiertas(Barco barco)
        {

            var cubiertas = cubiertasServicio.GetCubiertas(barco);
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

        private void CmbCodNav_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCubiertas((Barco)CmbCodNav.SelectedItem);
        }


        private void ConsultarCubiertas(Cubierta filtros)
        {
            var cubiertas = cubiertasServicio.GetCubiertas(filtros);
            

            foreach (var cubierta in cubiertas)
            {
                GetTripulantes(cubierta);
                TxtDesc.Text = cubierta.desc;
                

            }


        }
        private void GetTripulantes(Cubierta cubierta)
        {
            var tripulantes = cubiertasServicio.GetTripulantes();
            var tripulanteDefault = new Tripulante();
            tripulanteDefault.legajo = cubierta.leg_encargado;


            tripulantes.Add(tripulanteDefault);
            var conector = new BindingSource();
            conector.DataSource = tripulantes;

            CmbLegEnc.DataSource = conector;
            CmbLegEnc.DisplayMember = "legajo";
            CmbLegEnc.ValueMember = "legajo";
            CmbLegEnc.SelectedItem = tripulanteDefault;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var filtros = new Cubierta();
            filtros.cod_navio = (int)CmbCodNav.SelectedValue;
            filtros.num_cubierta = (int)CmbNumCub.SelectedValue;


            ConsultarCubiertas(filtros);


        }

        private void modificar(Cubierta cubierta)
        {
            cubiertasServicio.ModificarCubierta(cubierta);
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            var cubierta = generarCambio();
            
            modificar(cubierta);

            MessageBox.Show("Modificacion registrada Con éxito", "Modificar Cubierta ", MessageBoxButtons.OK);

        }

        private Cubierta generarCambio()
        {
            var cubierta = new Cubierta();
            cubierta.cod_navio = (int)CmbCodNav.SelectedValue;
            cubierta.num_cubierta = (int)CmbNumCub.SelectedValue;
            cubierta.desc = TxtDesc.Text;
            cubierta.leg_encargado = (int)CmbLegEnc.SelectedValue;

            return cubierta;
        }

        private void CmbLegEnc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var cubierta = generarCambio();

            modificar(cubierta);
        }
    }
}

using Pav_TP.Entidades;
using Pav_TP.Servicios;
using seastar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pav_TP.InterfacesDeUsuario.Camarote
{
    public partial class ConsultarCamarote : Form
    {
        SqlConnection myconn;
        private readonly CamaroteServicios camaroteServicios;
        //Cuando termines hace el FormClosing
        private readonly FrmPrincipal frmPrincipal;
        public ConsultarCamarote(FrmPrincipal f)
        {
            camaroteServicios = new CamaroteServicios();
            string conbas = "Data Source=200.69.137.167,11333;Initial Catalog=PAV_3K2_2022_12;User ID=PAV_3K2_2022_12;Password=PAV_3K2_2022_12";
            myconn = new SqlConnection();
            myconn.ConnectionString = conbas;
            myconn.Open();
            frmPrincipal = f;
            InitializeComponent();
        }

        private void ConsultarCamarote_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pAV_3K2_2022_12DataSet5.camarotes' table. You can move, or remove it, as needed.
            //this.camarotesTableAdapter.Fill(this.pAV_3K2_2022_12DataSet5.camarotes);
            camaroteServicios.CargarBarcos(CmbNavio);

        }

        private void CargarCubierta(int b)
        {
            var cubiertasXBarco = camaroteServicios.GetCubiertas(b);
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

        private void CargarGrillaCamarotes()
        {
            SqlCommand consultar = new SqlCommand();
            consultar.CommandType = CommandType.Text;
            consultar.Connection = myconn;
            consultar.CommandText = "select * from camarotes";
            DataTable midata = new DataTable();
            midata.Load(consultar.ExecuteReader());
            GrillaCamarotes.DataSource = midata;

        }

        private void CmbCubierta_Click(object sender, EventArgs e)
        {
            CargarCubierta(Convert.ToInt32(CmbNavio.SelectedValue));
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            /*try
            {*/
            SqlCommand consultar = new SqlCommand();
            consultar.CommandType = CommandType.Text;
            consultar.Connection = myconn;
            consultar.CommandText = "select c.cod_navio, c.num_cubierta, c.num_camarote, c.tipo, c.cant_camas from camarotes c";

            if (!string.IsNullOrEmpty(CmbNavio.SelectedValue.ToString()))
                consultar.CommandText += $" where c.cod_navio = {CmbNavio.SelectedValue}";
            else
            {
                MessageBox.Show("Ingrese un valor en el campo navio");
                CmbNavio.Focus();
            }
            if (!string.IsNullOrEmpty(CmbCubierta.SelectedValue.ToString()))
                consultar.CommandText += $" and c.num_cubierta = {CmbCubierta.SelectedValue}";
            else
            {
                MessageBox.Show("Ingrese un valor en el campo cubierta");
                CmbCubierta.Focus();
            }
            if (!string.IsNullOrEmpty(TxtNro.Text))
                consultar.CommandText += $" and c.num_camarote = {Convert.ToInt32(TxtNro.Text)}";

            DataTable midata = new DataTable();
            midata.Load(consultar.ExecuteReader());
            GrillaCamarotes.DataSource = midata;
            /*}
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Error 404... Revise los campos de busqueda");
            }*/


        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Form registrarCamarote = new RegistrarCamarote();
            registrarCamarote.ShowDialog();
            CargarGrillaCamarotes();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow lis in GrillaCamarotes.Rows)
            {
                if (Convert.ToBoolean(lis.Cells[6].Value) == true)
                {
                    var cTemp = new Pav_TP.Entidades.Camarote();
                    //Si se busca el camarote, las columnas de la grilla que referencian cod_navio y num_Cubierta valen null en la grilla
                    //Habria que hacer una condicion y seleccionar los datos de la grilla si no se busco nada
                    //o del cmb si se apreto el boton buscar

                    cTemp.cod_navio = Convert.ToInt32(lis.Cells[0].Value.ToString());
                    cTemp.num_cubierta = Convert.ToInt32(lis.Cells[1].Value.ToString());
                    cTemp.num_camarote = Convert.ToInt32(lis.Cells[2].Value.ToString());

                    
                    camaroteServicios.EliminarCamarote(cTemp);
                    
                    //Agregar pregunta: Esta seguro de que desea eliminar este camarote?

                }
            }
            CargarGrillaCamarotes();
        }

        private void CerrarFormulario()
        {
            frmPrincipal.Show();
            this.Dispose();
        }

        private void ConsultarCamarote_FormClosing(object sender, FormClosingEventArgs e)
        {
                CerrarFormulario();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
                CerrarFormulario();
        }
    }
}

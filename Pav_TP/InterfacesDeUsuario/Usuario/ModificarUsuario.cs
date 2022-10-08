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

namespace Pav_TP.InterfacesDeUsuario.Usuario
{
    public partial class ModificarUsuario : Form
    {
        SqlConnection myconn;
        private readonly FrmPrincipal frmPrincipal;
        public ModificarUsuario(FrmPrincipal f)
        {
            frmPrincipal = f;
            InitializeComponent();
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pAV_3K2_2022_12DataSet1.usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.pAV_3K2_2022_12DataSet1.usuarios);
            string conbas = "Data Source=200.69.137.167,11333;Initial Catalog=PAV_3K2_2022_12;User ID=PAV_3K2_2022_12;Password=PAV_3K2_2022_12";
            myconn = new SqlConnection();
            myconn.ConnectionString = conbas;
            myconn.Open();
            SqlCommand myconn2 = new SqlCommand();
            myconn2.CommandType = CommandType.Text;
            myconn2.Connection = myconn;
            myconn2.CommandText = "SELECT * FROM perfiles p";
            DataTable datoperfil = new DataTable();
            datoperfil.Load(myconn2.ExecuteReader());
            CmbPerfil.DataSource = datoperfil;
            CmbPerfil.DisplayMember = "descripcion";
            CmbPerfil.ValueMember = "id_perfil";

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            SqlCommand consultar = new SqlCommand();
            consultar.CommandType = CommandType.Text;
            consultar.Connection = myconn;
            consultar.CommandText = "select * from usuarios";
            if (TxtNombre.Text != "")
            {
                consultar.CommandText += " where usuario like '" + TxtNombre.Text + "%'";
            }
            DataTable midata = new DataTable();
            midata.Load(consultar.ExecuteReader());
            GrillaUsuario.DataSource = midata;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            SqlCommand modificar = new SqlCommand();
            modificar.CommandType = CommandType.Text;
            modificar.Connection = myconn;
            foreach (DataGridViewRow lis in GrillaUsuario.Rows)
            {
                if (Convert.ToBoolean(lis.Cells[3].Value) == true)
                {
                    /*update usuarios
                    set usuario = 'Nacho1'
                    where usuario = 'Nacho'*/
                    modificar.CommandText = "UPDATE usuarios set usuario = '" + TxtNombreM.Text + "', contraseña = '" + TxtContraseniaM.Text + "', perfil = " + CmbPerfil.SelectedValue.ToString() + " WHERE usuario = '" + lis.Cells[0].Value.ToString() + "'";
                    modificar.ExecuteNonQuery();
                    MessageBox.Show("El usuario se ha modificado con exito");
                    TxtNombreM.Text = "";
                    TxtContraseniaM.Text = "";
                    TxtNombre.Text = "";
                    TxtNombre.Focus();

                }
            }
            SqlCommand consultar = new SqlCommand();
            consultar.CommandType = CommandType.Text;
            consultar.Connection = myconn;
            consultar.CommandText = "select * from usuarios";
            DataTable midata = new DataTable();
            midata.Load(consultar.ExecuteReader());
            GrillaUsuario.DataSource = midata;
        }
        private void CerrarFormulario()
        {
            frmPrincipal.Show();
            this.Dispose();

        }

        private void ModificarUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarFormulario();
        }
    }
}

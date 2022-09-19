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
    public partial class RegistrarUsuario : Form
    {
        SqlConnection myconn;
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {
            string conbas = "Data Source=200.69.137.167,11333;Initial Catalog=PAV_3K2_2022_12;User ID=PAV_3K2_2022_12;Password=PAV_3K2_2022_12";
            myconn = new SqlConnection
            {
                ConnectionString = conbas
            };
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlCommand registrar = new SqlCommand();
            registrar.CommandType = CommandType.Text;
            registrar.Connection = myconn;
            registrar.CommandText = "INSERT INTO usuarios (usuario,contraseña,perfil)" +
                "VALUES ('" + TxtNombre.Text + "','" + TxtContrasenia.Text+ "','"+CmbPerfil.SelectedValue.ToString()+"')";
            registrar.ExecuteNonQuery();
            TxtNombre.Text = "";
            TxtContrasenia.Text = "";
            TxtNombre.Focus();
            MessageBox.Show("Se cargo con exito");

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

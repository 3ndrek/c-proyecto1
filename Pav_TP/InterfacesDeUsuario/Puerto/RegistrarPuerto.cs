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

namespace Pav_TP.InterfacesDeUsuario.Puerto
{
    public partial class RegistrarPuerto : Form
    {
        SqlConnection myconn;
        public RegistrarPuerto()
        {
            InitializeComponent();
        }

        private void RegistrarPuerto_Load(object sender, EventArgs e)
        {
            string conbas = "Data Source=200.69.137.167,11333;Initial Catalog=PAV_3K2_2022_12;User ID=PAV_3K2_2022_12;Password=PAV_3K2_2022_12";
            myconn = new SqlConnection
            {
                ConnectionString = conbas
            };
            myconn.Open();
        }

        private void btbRegistrar_Click(object sender, EventArgs e)
        {
            SqlCommand registrar = new SqlCommand();
            registrar.CommandType = CommandType.Text;
            registrar.Connection = myconn;
            registrar.CommandText = "INSERT INTO puertos (cod_puerto,nombre)" +
                "VALUES (" + txtCodigo.Text + ",'" +txtNombre.Text + "')";
            registrar.ExecuteNonQuery();
            txtNombre.Text = "";
            txtCodigo.Text = "";
            txtNombre.Focus();


            MessageBox.Show("Se cargo con exito");
        }
    }
}

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

namespace TrabajoPracticoPav
{
    public partial class RegistrarTripulante : Form
    {
        SqlConnection myconn;

        public RegistrarTripulante()
        {
            InitializeComponent();
        }

        private void RegistrarTripulante_Load(object sender, EventArgs e)
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
            myconn2.CommandText = "SELECT * FROM puestos";
            DataTable datopuesto = new DataTable();
            datopuesto.Load(myconn2.ExecuteReader());
            cmbCod.DataSource = datopuesto;
            cmbCod.DisplayMember = "desc";
            cmbCod.ValueMember = "cod_puesto";

            SqlCommand myconn3 = new SqlCommand();
            myconn3.CommandType = CommandType.Text;
            myconn3.Connection = myconn;
            myconn3.CommandText = "SELECT * FROM usuarios";
            DataTable datousuario = new DataTable();
            datousuario.Load(myconn3.ExecuteReader());
            comboBoxUsuario.DataSource = datousuario;
            comboBoxUsuario.DisplayMember = "usuario";
            comboBoxUsuario.ValueMember = "usuario";

            SqlCommand myconn4 = new SqlCommand();
            myconn4.CommandType = CommandType.Text;
            myconn4.Connection = myconn;
            myconn4.CommandText = "SELECT * FROM tripulantes WHERE jefe is NULL";
            DataTable datojefe = new DataTable();
            datojefe.Load(myconn4.ExecuteReader());
            comboBoxJefe.DataSource = datojefe;
            comboBoxJefe.DisplayMember = "nombre";
            comboBoxJefe.ValueMember = "legajo";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlCommand registrar = new SqlCommand();
            registrar.CommandType = CommandType.Text;
            registrar.Connection = myconn;
            registrar.CommandText = "INSERT INTO tripulantes (jefe,nombre,apellido,email,fechaNac,usuario,puesto)" +
                "VALUES (" + comboBoxJefe.SelectedValue.ToString() + ",'" + TxtNom.Text + "','" + TxtApe.Text + "','" + TxtEmail.Text + "','"+ Convert.ToDateTime(dateTimePicker1.Value.Date.ToString("yyyy-MM-dd")) + "','" + comboBoxUsuario.SelectedValue.ToString() + "'," + cmbCod.SelectedValue.ToString() + ")";
            registrar.ExecuteNonQuery();
            TxtNom.Text = "";
            TxtApe.Text = "";
            TxtEmail.Text = "";
            TxtNom.Focus();

        }
      

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}

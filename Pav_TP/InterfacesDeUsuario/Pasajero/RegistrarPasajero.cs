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
    public partial class RegistrarPasajero : Form
    {

        SqlConnection myconn;
        public RegistrarPasajero()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
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
            myconn2.CommandText = "SELECT * FROM tipo_doc";
            DataTable datotipo = new DataTable();
            datotipo.Load(myconn2.ExecuteReader());
            comboBoxDni.DataSource = datotipo;
            comboBoxDni.DisplayMember = "desc";
            comboBoxDni.ValueMember = "tipo";

            SqlCommand myconn3 = new SqlCommand();
            myconn3.CommandType = CommandType.Text;
            myconn3.Connection = myconn;
            myconn3.CommandText = "SELECT C.cod_ciudad , c.nombre FROM paisesXciudades PC join ciudades C on PC.cod_ciudad=C.cod_ciudad";
            DataTable datociudad = new DataTable();
            datociudad.Load(myconn3.ExecuteReader());
            comboBoxCiudad.DataSource = datociudad;
            comboBoxCiudad.DisplayMember = "nombre";
            comboBoxCiudad.ValueMember = "cod_ciudad";

            SqlCommand myconn4 = new SqlCommand();
            myconn4.CommandType = CommandType.Text;
            myconn4.Connection = myconn;
            myconn4.CommandText = "SELECT * FROM paises";
            DataTable datopais = new DataTable();
            datopais.Load(myconn4.ExecuteReader());
            comboBoxPais.DataSource = datopais;
            comboBoxPais.DisplayMember = "nombre";
            comboBoxPais.ValueMember = "cod_pais";

            SqlCommand myconn5 = new SqlCommand();
            myconn5.CommandType = CommandType.Text;
            myconn5.Connection = myconn;
            myconn5.CommandText = "SELECT * FROM genero";
            DataTable datogenero = new DataTable();
            datogenero.Load(myconn5.ExecuteReader());
            comboBoxGenero.DataSource = datogenero;
            comboBoxGenero.DisplayMember = "desc";
            comboBoxGenero.ValueMember = "tipo";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

            SqlCommand registrar = new SqlCommand();
            registrar.CommandType = CommandType.Text;
            registrar.Connection = myconn;
            registrar.CommandText = "INSERT INTO pasajeros (tipo_doc,num_doc,nombre,apellido,ciudad_procedente,pais_procedente,email,fechaNac,genero)" +
                "VALUES (" + comboBoxDni.SelectedValue.ToString() + ",'" + TxtDni.Text +"','" + TxtNom.Text + "','" +TxtApe.Text + "'," + comboBoxCiudad.SelectedValue.ToString() + "," + comboBoxPais.SelectedValue.ToString() + ",'" + TxtEmail.Text + "','" + dateTimePicker2.Text + "'," + comboBoxGenero.SelectedValue.ToString() + ")";
            registrar.ExecuteNonQuery();
            TxtDni.Text = "";
            TxtNom.Text = "";
            TxtApe.Text = "";
            TxtEmail.Text = "";
            TxtDni.Focus();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {

        }

       
    }
}

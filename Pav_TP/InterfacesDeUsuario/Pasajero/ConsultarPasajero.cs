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
    public partial class ConsultarPasajero : Form
    {
        SqlConnection myconn;
        public ConsultarPasajero()
        {
            InitializeComponent();
        }

        private void ConsultarPasajero_Load(object sender, EventArgs e)
        {
            string conbas = "Data Source=200.69.137.167,11333;Initial Catalog=PAV_3K2_2022_12;User ID=PAV_3K2_2022_12;Password=PAV_3K2_2022_12";
            myconn = new SqlConnection();
            myconn.ConnectionString = conbas;
            myconn.Open();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlCommand consultar = new SqlCommand();
            consultar.CommandType = CommandType.Text;
            consultar.Connection = myconn;
            consultar.CommandText = "SELECT * FROM pasajeros";
            if (TxtDni.Text != "")
            {
                consultar.CommandText += " WHERE num_doc like '%" + TxtDni.Text + "%'";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form registrarPasajero = new RegistrarPasajero();
            registrarPasajero.ShowDialog();
        }
    }
}

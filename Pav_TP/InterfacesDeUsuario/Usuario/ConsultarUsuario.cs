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
    public partial class ConsultarUsuario : Form
    {
        SqlConnection myconn;
        public ConsultarUsuario()
        {
            InitializeComponent();
        }

        private void ConsultarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pAV_3K2_2022_12DataSet.usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.pAV_3K2_2022_12DataSet.usuarios);
            string conbas = "Data Source=200.69.137.167,11333;Initial Catalog=PAV_3K2_2022_12;User ID=PAV_3K2_2022_12;Password=PAV_3K2_2022_12";
            myconn = new SqlConnection();
            myconn.ConnectionString = conbas;
            myconn.Open();

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
            //MessageBox.Show("Usuario: Nombre: " + midata.Rows[0][0].ToString() + " contraseña:" + midata.Rows[0][1].ToString());


        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            SqlCommand eliminar = new SqlCommand();
            eliminar.CommandType = CommandType.Text;
            eliminar.Connection = myconn;
            foreach (DataGridViewRow lis in GrillaUsuario.Rows)
            {
                if (Convert.ToBoolean(lis.Cells[3].Value) == true)
                {
                    eliminar.CommandText = "DELETE FROM usuarios WHERE usuario = '" + lis.Cells[0].Value.ToString() +"'";
                    eliminar.ExecuteNonQuery();

                    
                    MessageBox.Show("El usuario "+(string)lis.Cells[0].Value+"ha sido eliminado.");
                    
                }
            }
            SqlCommand consultar = new SqlCommand();
            consultar.CommandType = CommandType.Text;
            consultar.Connection = myconn;
            consultar.CommandText = "select * from usuarios";
            DataTable midata = new DataTable();
            midata.Load(consultar.ExecuteReader());
            GrillaUsuario.DataSource = midata;
            //MessageBox.Show("Usuario: Nombre: " + midata.Rows[0][0].ToString() + " contraseña:" + midata.Rows[0][1].ToString());
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Form registrarUsuario = new RegistrarUsuario();
            registrarUsuario.ShowDialog();
            SqlCommand consultar = new SqlCommand();
            consultar.CommandType = CommandType.Text;
            consultar.Connection = myconn;
            consultar.CommandText = "select * from usuarios";
            DataTable midata = new DataTable();
            midata.Load(consultar.ExecuteReader());
            GrillaUsuario.DataSource = midata;


        }
    }
}

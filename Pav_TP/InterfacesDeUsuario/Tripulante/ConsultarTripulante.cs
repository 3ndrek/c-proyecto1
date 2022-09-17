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
    public partial class ConsultarTripulante : Form
    {
        SqlConnection myconn;
        public ConsultarTripulante()
        {
            InitializeComponent();
        }

       

        private void ConsultarTripulante_Load(object sender, EventArgs e)
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
            consultar.CommandText = "SELECT * FROM tripulantes";
            if (TxtLegajo.Text != "")
            {
                consultar.CommandText += " WHERE legajo like '%" + TxtLegajo.Text + "%'";
            }

           // DataTable midata = new DataTable();
           // midata.Load(consultar.ExecuteReader());
           // GrillaTripulante.DataSource = midata;
           // MessageBox.Show("Usuario: ID" + midata.Rows[0][0].ToString() + " Nombre:" + midata.Rows[0][2].ToString());

        }

        private void genero_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form registrarTripulante = new RegistrarTripulante();
            registrarTripulante.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
           foreach (DataGridViewRow lis in GrillaTripulante.Rows)
               {
            
                 if (Convert.ToBoolean(lis.Cells[0].Value) == true)
               {
                 GrillaTripulante.Rows.RemoveAt(lis.Index);
            

            }
            }
        }
        }
    }

    


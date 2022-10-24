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

namespace Pav_TP.InterfacesDeUsuario.Usuario
{
    public partial class ConsultarUsuario : Form
    {
        private readonly UsuariosServicio usuariosServicios;
        private readonly FrmPrincipal frmPrincipal;
        public ConsultarUsuario(FrmPrincipal f)
        {
            usuariosServicios = new UsuariosServicio();
            frmPrincipal = f;
            InitializeComponent();
        }

        private void ConsultarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            /*SqlCommand eliminar = new SqlCommand();
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
            GrillaUsuario.DataSource = midata;*/
            //MessageBox.Show("Usuario: Nombre: " + midata.Rows[0][0].ToString() + " contraseña:" + midata.Rows[0][1].ToString());
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            
        }
        private void CerrarFormulario()
        {
            frmPrincipal.Show();
            this.Dispose();

        }

        private void ConsultarUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarFormulario();
        }
    }
}

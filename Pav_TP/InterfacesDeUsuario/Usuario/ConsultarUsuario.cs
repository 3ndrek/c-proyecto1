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
            usuariosServicios.CargarUsuarios(GrillaUsuario);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            usuariosServicios.BuscarUsuario(GrillaUsuario, TxtNombre.Text);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Form eliminarUsuario = new EliminarUsuario();
            eliminarUsuario.ShowDialog();
            usuariosServicios.CargarUsuarios(GrillaUsuario);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Form registraUsuario = new RegistrarUsuario();
            registraUsuario.ShowDialog();
            usuariosServicios.CargarUsuarios(GrillaUsuario);
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

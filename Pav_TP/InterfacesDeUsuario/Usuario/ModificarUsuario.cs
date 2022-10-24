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
    public partial class ModificarUsuario : Form
    {
        private readonly UsuariosServicio usuariosServicio;
        private readonly FrmPrincipal frmPrincipal;
        public ModificarUsuario(FrmPrincipal f)
        {
            frmPrincipal = f;
            usuariosServicio = new UsuariosServicio();
            InitializeComponent();
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            usuariosServicio.CargarUsuarios(GrillaUsuario);
            //No carga la grilla... Resolver
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            
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

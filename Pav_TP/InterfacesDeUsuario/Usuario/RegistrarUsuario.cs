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
    public partial class RegistrarUsuario : Form
    {
        private readonly UsuariosServicio usuariosServicio;
        private readonly FrmPrincipal frmPrincipal;

        public RegistrarUsuario()
        {
            usuariosServicio = new UsuariosServicio();
            InitializeComponent();
        }
        public RegistrarUsuario(FrmPrincipal f)
        {
            frmPrincipal = f;
            usuariosServicio = new UsuariosServicio();
            InitializeComponent();
        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {
            usuariosServicio.CargarPerfiles(CmbPerfil);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(CmbPerfil.SelectedValue.ToString());
            try
            {
            var usuario = new Entidades.Usuario();
            usuario.NombreUsuario = TxtNombre.Text;
            usuario.Contrasenia = TxtContrasenia.Text;
            usuario.Perfil = Convert.ToInt64(CmbPerfil.SelectedValue.ToString());
            usuariosServicio.RegistrarUsuario(usuario);

            TxtNombre.Text = "";
            TxtContrasenia.Text = "";
            usuariosServicio.CargarPerfiles(CmbPerfil);
            TxtNombre.Focus();

            MessageBox.Show("El usuario se registro con exito.");

            }
            catch (Exception)
            {
                MessageBox.Show("Registro invalido... Verifique los campos", "Error 404", MessageBoxButtons.OK);
            }

        }
        private void CerrarFormulario()
        {
            if(frmPrincipal != null)
            {
                frmPrincipal.Show();
                this.Dispose();
            }
            else 
                this.Dispose();

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void RegistrarUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarFormulario();
        }
    }
}

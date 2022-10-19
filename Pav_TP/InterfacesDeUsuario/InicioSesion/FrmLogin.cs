using Pav_TP.Entidades;
using Pav_TP.Servicios;
using seastar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV1
{
    public partial class FrmLogin : Form

    {
        private readonly UsuariosServicio usuarioServicio;
        private readonly FrmPrincipal frmPrincipal;
        public Boolean VarCierre; 

        //private object usuariosServicio;

        public FrmLogin(FrmPrincipal frmPrincipal)
        {
            InitializeComponent();
            usuarioServicio = new UsuariosServicio();
            frmPrincipal = new FrmPrincipal();
        }

        private void CerrarFormulario()
        {
            DialogResult result = MessageBox.Show("Desea cerrar el programa?", " inicio de sesion ", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                VarCierre = true;
                usuarioServicio.CierrePrograma(VarCierre);
            }

            if (result == DialogResult.Cancel)
            {
                VarCierre = false;
                usuarioServicio.CierrePrograma(VarCierre);
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UsuariosServicio.UsuarioLogueado != null)
            {
                this.Dispose();
            }
            else
            {
                CerrarFormulario();
            }
        }



        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.NombreUsuario = TxtUsuario.Text.Trim();
            usuario.Contrasenia = TxtContrasenia.Text.Trim();

            if (usuarioServicio.Login(usuario))
            {
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña inválidas", "Información", MessageBoxButtons.OK);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using Pav_TP.Entidades;
using Pav_TP.Servicios;
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

        //private object usuariosServicio;

        public FrmLogin()
        {
            InitializeComponent();
            usuarioServicio = new UsuariosServicio();
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
        private void CerrarFormulario()
        {
            this.Dispose();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarFormulario();
        }
    }
}

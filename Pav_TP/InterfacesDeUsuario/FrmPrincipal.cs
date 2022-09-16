using Pav_TP.Servicios;
using PAV1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pav_TP
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (UsuariosServicio.UsuarioLogueado == null)
            {
                var frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
                /*LblBienvenida.Text = $"Bienvenido {UsuariosServicio.UsuarioLogueado.NombreCompleto}.";
                LblBienvenida.Text += $"Perfil {UsuariosServicio.UsuarioLogueado.Perfil.Nombre}";
            }
            else
            {
                LblBienvenida.Text = $"Bienvenido {UsuariosServicio.UsuarioLogueado.NombreCompleto}.";
                LblBienvenida.Text += $"Perfil {UsuariosServicio.UsuarioLogueado.Perfil.Nombre}";
                */
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Lo cree sin querer... 'nacho'
        }
    }
}

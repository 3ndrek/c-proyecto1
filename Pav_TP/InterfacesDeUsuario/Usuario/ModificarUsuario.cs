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
            usuariosServicio.CargarPerfiles(CmbPerfil);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            usuariosServicio.BuscarUsuario(GrillaUsuario, TxtBuscar.Text);
            usuariosServicio.CargarPerfiles(CmbPerfil);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            var usuarioM = CrearUsuarioParaModificar();

            if (usuarioM != null)
            {
                usuariosServicio.ModificarUsuario(usuarioM);
                usuariosServicio.CargarUsuarios(GrillaUsuario);
                TxtNombre.Text = "";
                TxtContraseniaM.Text = "";
                usuariosServicio.CargarPerfiles(CmbPerfil);
                TxtBuscar.Focus();
                MessageBox.Show("Usuario modificado con exito");
            }
            else MessageBox.Show("Ingrese el nombre del usuario que desea modificar");
        }

        private Entidades.Usuario CrearUsuarioParaModificar()
        {
            if (TxtNombre.Text != "")
            {
                var usuarioM = new Entidades.Usuario();
                usuarioM.NombreUsuario = TxtNombre.Text;
                usuarioM.Contrasenia = TxtContraseniaM.Text;
                usuarioM.Perfil = (long)CmbPerfil.SelectedValue;
                return usuarioM;
            }

            else
            {
                return null;
            }
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

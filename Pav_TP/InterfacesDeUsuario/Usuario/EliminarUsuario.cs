using Pav_TP.Repositorios;
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

namespace Pav_TP.InterfacesDeUsuario.Usuario
{
    public partial class EliminarUsuario : Form
    {
        private readonly UsuariosServicio usuariosServicio;
        public EliminarUsuario()
        {
            usuariosServicio = new UsuariosServicio();
            InitializeComponent();
        }

        private void CerrarForm()
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text != "" && usuariosServicio.BuscarUsuarioParaEliminar(txtNombre.Text) == 1)
            {
                var usuario = new Entidades.Usuario();
                usuario.NombreUsuario = txtNombre.Text;
                usuariosServicio.EliminarUsuario(usuario);
                MessageBox.Show("El usuario se elimino con exito.");
            }
            else { 
                MessageBox.Show("El nombre de usuario no existe. Porfavor intente de nuevo.");
                txtNombre.Text = "";
                txtNombre.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CerrarForm();
        }

        private void EliminarUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarForm();
        }
    }
}

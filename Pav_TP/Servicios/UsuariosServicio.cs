using Pav_TP.Entidades;
using Pav_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pav_TP.Servicios
{
    public class UsuariosServicio
    {
        private readonly UsuariosRepositorio usuariosRepositorio;
        public static Usuario UsuarioLogueado;

        public static Boolean VarCierre;

        public UsuariosServicio()
        {
            usuariosRepositorio = new UsuariosRepositorio();
        }
        public bool Login(Usuario usuario)
        {
            var usuarioLogueado = usuariosRepositorio.LoginBD(usuario);
            if (usuarioLogueado == null)
                return false;
            UsuarioLogueado = usuarioLogueado;
            return true;
        }
        public void RegistrarUsuario(Usuario usuario) { usuariosRepositorio.RegistrarUsuario(usuario); }
        public void ModificarUsuario(Usuario usuario) { usuariosRepositorio.ModificarUsuario(usuario); }
        public void ConsultarUsuario(Usuario usuario) { usuariosRepositorio.ConsultarUsuario(usuario); }
        public void EliminarUsuario(Usuario usuario) { usuariosRepositorio.EliminarUsuario(usuario); }
        public List<Usuario> GetUsuarios() { return usuariosRepositorio.GetUsuarios(); }
        public List<Perfil> GetPerfiles() { return usuariosRepositorio.GetPerfil(); }
        public void CargarUsuarios(DataGridView dgv) { usuariosRepositorio.CargarGrillaUsuarios(dgv); }
        public void BuscarUsuario(DataGridView dgv, string nombre) { usuariosRepositorio.BuscarUsuario(dgv, nombre); }
        public int BuscarUsuarioParaEliminar(string nombre) { return usuariosRepositorio.BuscarUsuarioParaEliminar(nombre); }

        public void CargarPerfiles(ComboBox cmb)
        {
            var perfiles = GetPerfiles();
            var perfilDefault = new Perfil();
            perfilDefault.Id = 0;
            perfilDefault.Nombre = "";
            perfiles.Add(perfilDefault);

            var conector = new BindingSource();
            conector.DataSource = perfiles;

            cmb.DataSource = conector;
            cmb.DisplayMember = "Nombre";
            cmb.ValueMember = "Id";
            cmb.SelectedItem = perfilDefault;
        }


        public void CierrePrograma (Boolean b)
        {
            VarCierre = b; 
        }


    }
}

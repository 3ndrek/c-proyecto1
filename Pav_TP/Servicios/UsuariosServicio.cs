using Pav_TP.Entidades;
using Pav_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Servicios
{
    public class UsuariosServicio
    {
        private readonly UsuariosRepositorio usuariosRepositorio;
        public static Usuario UsuarioLogueado;

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

        /*public List<Usuario> GetUsuarios()
        {
            return usuariosRepositorio.GetUsuarios();
        }
        */
        /*public List<Usuario> GetUsuarios(Usuario filtros, bool soloActivo)
        {
            return usuariosRepositorio.GetUsuarios(filtros, soloActivo);
        }*/
    }
}

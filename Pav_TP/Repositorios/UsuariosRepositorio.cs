using Pav_TP.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Repositorios
{
    public class UsuariosRepositorio
    {
        //Hay que ver si hace falta el perfil... Y como usarlo en el login
        //Si no sirve hay que redefininr la consulta
        public Usuario LoginBD(Usuario usuario)
        {
            //var sql = $"SELECT u.*, p.nombre as perfil FROM Usuarios u LEFT JOIN Perfiles p ON u.id_perfil = p.id_perfil where activo='S' and usuario='{usuario.NombreUsuario}' and password='{usuario.Contrasenia}'";
            var sql = $"SELECT u.* FROM Usuarios u where usuario='{usuario.NombreUsuario}' and contraseña='{usuario.Contrasenia}'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            Usuario usuarioLoguado = null;
            if (tablaResultado.Rows.Count == 1)
            {
                var fila = tablaResultado.Rows[0];
                usuarioLoguado = new Usuario();
                usuarioLoguado.NombreUsuario = fila["usuario"].ToString();
                //usuarioLoguado.Id = Convert.ToInt64(fila["id_usuario"].ToString());
                // activo
                //var activo = fila["activo"].ToString();
                //usuarioLoguado.Estado = activo == "S";

                // perfil
                /*var perfil = new Perfil();
                perfil.Nombre = fila["perfil"].ToString();
                perfil.Id = Convert.ToInt64(fila["id_perfil"].ToString());
                usuarioLoguado.Perfil = perfil;*/
            }

            return usuarioLoguado;
        }
        //Este metodo hay que ver si es util porque muestra una lista de usuarios...
        /*public List<Usuario> GetUsuarios()
        {
            var sql = $"SELECT u.*, p.nombre as perfil FROM Usuarios u LEFT JOIN Perfiles p ON u.id_perfil = p.id_perfil";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var usuarios = new List<Usuario>();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var usuarioLogueado = new Usuario();
                usuarioLogueado.NombreUsuario = fila["usuario"].ToString();
                usuarioLogueado.Id = Convert.ToInt64(fila["id_usuario"].ToString());
                // activo
                var activo = fila["activo"].ToString();
                usuarioLogueado.Estado = activo == "S";

                // perfil
                var perfil = new Perfil();
                perfil.Nombre = fila["perfil"].ToString();
                perfil.Id = Convert.ToInt64(fila["id_perfil"].ToString());
                usuarioLogueado.Perfil = perfil;

                //agrego usuario a la lista usuarios
                usuarios.Add(usuarioLogueado);
            }

            return usuarios;
        }
        */

        //Este tambien hay que ver si sirve (Sobrecarga de "GetUsuarios()")
        /*
        public List<Usuario> GetUsuarios(Usuario filtro, bool soloActivos)
        {
            var sql = $"SELECT u.*, p.nombre as perfil FROM Usuarios u LEFT JOIN Perfiles p ON u.id_perfil = p.id_perfil WHERE 1=1";
            if (!string.IsNullOrEmpty(filtro.NombreCompleto))
            {
                sql += $"AND u.usuario like '%{filtro.NombreUsuario}%'";
            }
            if (filtro.Perfil != null && filtro.Perfil.Id != 0)
            {
                sql += $"AND u.id_perfil = {filtro.Perfil.Id}";
            }
            if (soloActivos)
            {
                sql += $"AND U.activo = 'S'";
            }
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var usuarios = new List<Usuario>();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var usuarioLogueado = new Usuario();
                usuarioLogueado.NombreUsuario = fila["usuario"].ToString();
                usuarioLogueado.Id = Convert.ToInt64(fila["id_usuario"].ToString());
                // activo
                var activo = fila["activo"].ToString();
                usuarioLogueado.Estado = activo == "S";

                // perfil
                var perfil = new Perfil();
                perfil.Nombre = fila["perfil"].ToString();
                perfil.Id = Convert.ToInt64(fila["id_perfil"].ToString());
                usuarioLogueado.Perfil = perfil;

                //agrego usuario a la lista usuarios
                usuarios.Add(usuarioLogueado);
            }

            return usuarios;
        }
        */
    }
}

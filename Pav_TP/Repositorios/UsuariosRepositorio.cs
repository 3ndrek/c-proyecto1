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
            var sql = $"SELECT u.* FROM Usuarios u where usuario='{usuario.NombreUsuario}' and contraseña='{usuario.Contrasenia}'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            Usuario usuarioLogueado = null;
            if (tablaResultado.Rows.Count == 1)
            {
                var fila = tablaResultado.Rows[0];
                usuarioLogueado = new Usuario();
                usuarioLogueado.NombreUsuario = fila["usuario"].ToString();
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

            return usuarioLogueado;
        }
       

        
    }
}

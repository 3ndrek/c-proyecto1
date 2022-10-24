using Pav_TP.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pav_TP.Repositorios
{
    public class UsuariosRepositorio
    {
        public Usuario LoginBD(Usuario usuario)
        {
            var sql = $"SELECT * FROM usuarios  where usuario='{usuario.NombreUsuario}' and contraseña='{usuario.Contrasenia}'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            Usuario usuarioLogueado = null;
            if (tablaResultado.Rows.Count == 1)
            {
                var fila = tablaResultado.Rows[0];
                usuarioLogueado = new Usuario();
                usuarioLogueado.NombreUsuario = fila["usuario"].ToString();
                //usuarioLogueado.Perfil.Id = Convert.ToInt32(fila["perfil"].ToString());
            }

            return usuarioLogueado;
        }

        public void RegistrarUsuario (Usuario usuario)
        {
            var sql = $"INSERT INTO usuarios (usuario,contraseña,perfil) " +
                $"VALUES ('{usuario.NombreUsuario}','{usuario.Contrasenia}', {usuario.Perfil})";
            DBHelper.GetDBHelper().EjecutarSQL(sql);
        }

        public void ModificarUsuario(Usuario usuario)
        {
            var sql = $"update usuarios  set contraseña = '{usuario.Contrasenia}', perfil = {usuario.Perfil} " +
                $"where usuario = '{usuario.NombreUsuario}'";
            DBHelper.GetDBHelper().EjecutarSQL(sql);
        }

        public void EliminarUsuario(Usuario usuario)
        {
            var sql = $"delete from usuarios where usuario = '{usuario.NombreUsuario}'";
            DBHelper.GetDBHelper().EjecutarSQL(sql);
        }

        public void ConsultarUsuario(Usuario usuario)
        {
            var sql = $"select from usuarios where usuario = '{usuario.NombreUsuario}'";
            DBHelper.GetDBHelper().EjecutarSQL(sql);
        }

        public List<Usuario> GetUsuarios()
        {
            var sql = $"select * from usuarios";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var usuarios = new List<Usuario>();
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var usuario = new Usuario();
                usuario.NombreUsuario = fila["usuario"].ToString();
                usuario.Contrasenia = fila["contraseña"].ToString();
                usuario.Perfil = Convert.ToInt64(fila["perfil"]);
                usuarios.Add(usuario);
            }
            return usuarios;

        }

        public List<Perfil> GetPerfil()
        {
            var sql = $"select * from perfiles";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var perfiles = new List<Perfil>();
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var perfil = new Perfil();
                perfil.Id = Convert.ToInt32(fila["Id_perfil"]);
                perfil.Nombre = fila["descripcion"].ToString();
                perfiles.Add(perfil);
            }
            return perfiles;

        }

        public void CargarGrillaUsuarios(DataGridView dgv)
        {
            var sql = "select * from usuarios";
            var midata = DBHelper.GetDBHelper().ConsultaSQL(sql);
            dgv.DataSource = midata;
            var col = new DataGridViewCheckBoxColumn();
            col.Name = "Seleccionar";
            dgv.Columns.Add(col);

        }

    }
}

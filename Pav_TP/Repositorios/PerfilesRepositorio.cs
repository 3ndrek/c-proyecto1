using Pav_TP.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Repositorios
{
    public class PerfilesRepositorio
    {
        public List<Perfil> GetPerfiles()
        {
            var sql = $"Select * from perfiles";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var perfiles = new List<Perfil>();
            foreach (DataRow fila in tabla.Rows)
            {
                var perfil = new Perfil();
                perfil.Id = Convert.ToInt64(fila["id_perfil"].ToString());
                perfil.Nombre = fila["nombre"].ToString();
                perfiles.Add(perfil);
            }

            return perfiles;
        }
    }
}

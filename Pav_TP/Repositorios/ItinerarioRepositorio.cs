using Pav_TP.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pav_TP.Repositorios
{
    public class ItinerarioRepositorio
    {
        public List<Paises> GetPaises()
        {
            var sql = "SELECT * from paises";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var paises = new List<Paises>();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var pais = new Paises();
                pais.cod_pais = Convert.ToInt32(fila["cod_pais"]);
                pais.nombre = fila["nombre"].ToString();
                paises.Add(pais);
            }
            return paises;
        }

        public List<CategoriasItinerarios> GetCategoriasItinerarios()
        {
            var sql = "SELECT * from categoriasItinerarios";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var categorias = new List<CategoriasItinerarios>();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var categoria = new CategoriasItinerarios();
                categoria.categoria = Convert.ToInt32(fila["categoria"]);
                categoria.descripcion = fila["descripcion"].ToString();
                categorias.Add(categoria);
            }
            return categorias;
        }

        public List<Puertos> GetPuertosXPais(int cod_pais)
        {
            var sql = $"select p.* from puertos p left join puertosXpaises pxp on p.cod_puerto = pxp.cod_puerto left join paises pa on pxp.cod_pais = pa.cod_pais where pa.cod_pais = {cod_pais}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var puertos = new List<Puertos>();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var puerto = new Puertos();
                puerto.cod_puerto = Convert.ToInt32(fila["cod_puerto"]);
                puerto.nombre = fila["nombre"].ToString();
                puertos.Add(puerto);
            }
            return puertos;
        }

        public int GenerarCodItinerario()
        {
            var sql = $"select count(i.cod_itinerario) from itinerarios i";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            int cod_itinerario = Convert.ToInt32(tablaResultado.Rows[0][0]);
            return cod_itinerario+1;

        }

        public void RegistrarPuertosXItinerario(int cod_i, int num_e, int cod_p)
        {
            var sql = $"insert into puertoXitinerarios(cod_itinerarios,num_escala,cod_puerto) values ({cod_i},{num_e},{cod_p})";
            DBHelper.GetDBHelper().EjecutarSQL(sql);
        }
        public int GetCodPais(string n)
        {
            var sql = $"select p.cod_pais from paises p where p.nombre = '{n}'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            DataRow row = tablaResultado.Rows[0];
            int cod_p = (int)row[0];
            return cod_p;
        }

        public int GetCodPuerto(string n)
        {
            var sql = $"select p.cod_puerto from puertos p where p.nombre = '{n}'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            DataRow row = tablaResultado.Rows[0];
            int cod_p = (int)row[0];
            return cod_p;
        }
    }
}

using Pav_TP.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Repositorios
{
    public class CubiertasRepositorio
    {
        public List<Barco> GetBarcos()
        {
            var sql = $"SELECT * from navio";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var barcos= new List<Barco>();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var barco = new Barco();
                barco.Codigo = Convert.ToInt32(fila["codigo_navio"]);
                barco.Nombre = fila["nombre"].ToString();
                barcos.Add(barco);
            }
            return barcos; 

        }

        public List<Cubierta> GetCubiertas(Barco f)
        {
            var sql = $"SELECT c.*, t.nombre,t.apellido from cubiertas c join tripulantes t on t.legajo = c.leg_encargado WHERE 1=1 "; 
            
            if (!string.IsNullOrEmpty(f.Codigo.ToString()))
            {
                sql += $" AND c.cod_navio = '{f.Codigo}'";
            }

            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var cubiertas = new List<Cubierta>();

            foreach (DataRow fila in tablaResultado.Rows )
            {
                var cubiertaFiltrada = new Cubierta();
                cubiertaFiltrada.cod_navio = Convert.ToInt32(fila["cod_navio"].ToString());
                cubiertaFiltrada.num_cubierta = Convert.ToInt32(fila["num_cubierta"].ToString());
                cubiertaFiltrada.desc = fila["desc"].ToString();
                cubiertaFiltrada.leg_encargado = Convert.ToInt32(fila["leg_encargado"].ToString());

                cubiertas.Add(cubiertaFiltrada);
            }

            return cubiertas;

        }
        public List<Cubierta> GetCubiertas(Cubierta f)
        {
            var sql = $"SELECT * from cubiertas  WHERE 1=1 ";

            if (!string.IsNullOrEmpty(f.cod_navio.ToString()))
            {
                sql += $" AND cod_navio = {f.cod_navio}";
            }
            if (!string.IsNullOrEmpty(f.num_cubierta.ToString()))
            {
                sql += $" AND num_cubierta = {f.num_cubierta}";
            }
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var cubiertas = new List<Cubierta>();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var cubiertaFiltrada = new Cubierta();
                cubiertaFiltrada.cod_navio = Convert.ToInt32(fila["cod_navio"].ToString());
                cubiertaFiltrada.num_cubierta = Convert.ToInt32(fila["num_cubierta"].ToString());
                cubiertaFiltrada.desc = fila["desc"].ToString();
                cubiertaFiltrada.leg_encargado = Convert.ToInt32(fila["leg_encargado"].ToString());

                cubiertas.Add(cubiertaFiltrada);
            }

            return cubiertas;

        }
    }
}

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
                cubiertaFiltrada.desc = fila["descripcion"].ToString();
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
                cubiertaFiltrada.desc = fila["descripcion"].ToString();
                cubiertaFiltrada.leg_encargado = Convert.ToInt32(fila["leg_encargado"].ToString());

                cubiertas.Add(cubiertaFiltrada);
            }

            return cubiertas;


        }

        public void EliminarCubiertas(Cubierta filtro)
        {
                var sql = $"DELETE from cubiertas WHERE cod_navio = {filtro.cod_navio} and num_cubierta = {filtro.num_cubierta}";
            DBHelper.GetDBHelper().EjecutarSQL(sql);




        }

        public List<Tripulante> CargaTripulantes()
        {
            var sql = $"SELECT * FROM tripulantes";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var cubiertas = new List<Tripulante>();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var tripulantebuscado = new Tripulante();
                tripulantebuscado.legajo = Convert.ToInt32(fila["legajo"].ToString());
                tripulantebuscado.nombre = fila["nombre"].ToString();
                tripulantebuscado.apellido = fila["apellido"].ToString();
                cubiertas.Add(tripulantebuscado);
            }
            return cubiertas;
        }


        public void RegistrarCubierta(Cubierta cubierta)
        {
            var sql = $"INSERT INTO cubiertas(cod_navio, descripcion, leg_encargado) values({cubierta.cod_navio},'{cubierta.desc}', {cubierta.leg_encargado})";
            DBHelper.GetDBHelper().EjecutarSQL(sql);
        }


        public void ModificarCubierta(Cubierta cubierta)
        {
            var sql = $"UPDATE cubiertas SET descripcion= '{cubierta.desc}', Leg_encargado= {cubierta.leg_encargado} WHERE cod_navio = {cubierta.cod_navio} and num_cubierta ={cubierta.num_cubierta}";
            DBHelper.GetDBHelper().EjecutarSQL(sql);
        }
    }
}

using Pav_TP.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Repositorios
{
    public class PuertosRepositorio
    {
        public List<Entidades.Puerto> GetPuertos()
        {
            var puertos = new List<Puerto>();
            var sentenciaSql = $"SELECT * FROM puertos WHERE esDAdoBaja is null";

            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var puerto = MapearPuerto(fila);
                puertos.Add(puerto);
            }

            return puertos;
        }

        public List<Puertos> GetPuertos(Itinerario itinerario)
        {
            var puertos = new List<Puertos>();
            var sentenciaSql = $"SELECT P.* FROM puertos P JOIN puertoXitinerarios PxI ON P.cod_puerto= PxI.cod_puerto JOIN itinerarios I ON PxI.cod_itinerarios = I.cod_itinerario WHERE I.cod_itinerario = {itinerario.Cod_Itinerario} AND P.esDAdoBaja is null";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var puerto = new Puertos();
                puerto.cod_puerto = Convert.ToInt32(fila["cod_puerto"]);
                puerto.nombre = fila["nombre"].ToString();

                puertos.Add(puerto);
            }

            return puertos;
        }

        public List<Puerto> GetPuertos(Puerto p)
        {
            var puertos = new List<Puerto>();
            var sentenciaSql = $"SELECT * FROM puertos WHERE nombre like '%{p.Nombre}%' AND esDAdoBaja is null";
            if (p.Codigo != 0)
                sentenciaSql += $" AND cod_puerto={p.Codigo}";

            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var puerto = MapearPuerto(fila);
                puertos.Add(puerto);
            }

            return puertos;
        }

        public Puerto GetPuertos(int id)
        {
            var puerto = new Puerto();
            var sentenciaSql = $"SELECT * FROM puertos WHERE cod_puerto={id} AND esDAdoBaja is null";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                puerto = MapearPuerto(fila);
            }

            return puerto;
        }

        private Puerto MapearPuerto(DataRow fila)
        {
            var puerto = new Puerto();
            puerto.Codigo = Convert.ToInt32(fila["cod_puerto"].ToString());
            puerto.Nombre = fila["nombre"].ToString();

            return puerto;
        }

        public int EliminarPuerto(int id)
        {
            var sentenciaSql = $"UPDATE puertos set esDAdoBaja=1 WHERE cod_puerto={id}";
            var filasAfectada = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);

            return filasAfectada;
        }

        public int RegistrarPuerto(Puerto p)
        {
            var sentenciaSql = $"INSERT INTO puertos (nombre) VALUES ('{p.Nombre}')";
            var filasAfectada = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);

            return filasAfectada;
        }

        public int ActualizarPuerto(Puerto p)
        {
            var sentenciaSql = $"UPDATE puertos SET nombre='{p.Nombre}' WHERE cod_puerto={p.Codigo}";

            var filasAfectada = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);

            return filasAfectada;
        }
    }
}

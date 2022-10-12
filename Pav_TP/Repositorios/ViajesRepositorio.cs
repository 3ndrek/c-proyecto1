﻿using Pav_TP.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Repositorios
{
    public class ViajesRepositorio
    {
        public List<Viaje> GetViajes()
        {
            var viajes = new List<Viaje>();
            var sentenciaSql = $"SELECT * FROM viaje";

            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var viaje = Mapear(fila);
                viajes.Add(viaje);
            }

            return viajes;
        }

        public List<Viaje> GetViajes(Viaje v)
        {
            var viajes = new List<Viaje>();
            var sentenciaSql = $"SELECT * FROM viaje WHERE cod_navio like '%{v.Cod_navio}%'AND fecha_viaje='{v.FechaSalida.ToString("yyyy-MM-dd")}'";

            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var viaje = Mapear(fila);
                viajes.Add(viaje);
            }

            return viajes;
        }

        public Viaje GetViajes(int id, DateTime fecha)
        {
            var viaje = new Viaje();
            var sentenciaSql = $"SELECT * FROM viaje  WHERE cod_navio= {id} AND tipo_doc={fecha}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                viaje = Mapear(fila);
            }

            return viaje;
        }
        public List<Itinerario> GetItinerario()
        {
            var itinerarios = new List<Itinerario>();
            var sentenciaSql = $"SELECT * FROM itinerarios";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var itinerario= new Itinerario();
                itinerario.Cod_Itinerario = Convert.ToInt32(fila["cod_itinerario"]);
                itinerario.Categoria = Convert.ToInt32(fila["categoria"]);


                itinerarios.Add(itinerario);
            }

            return itinerarios;
        }
        public int RegistrarViaje(Viaje v)
        {
            var sentenciaSql = $"INSERT INTO viaje (cod_navio, fecha_viaje, duracion, cod_itinerario, pais_origen, pais_destino) VALUES ({v.Cod_navio}, '{v.FechaSalida}', {v.Duracion}, {v.Itinerario}, {v.Origen}, {v.Destino})";
            var filasAfectada = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);

            return filasAfectada;
        }

        private Viaje Mapear(DataRow fila)
        {
            var viaje = new Viaje();
            viaje.Cod_navio = Convert.ToInt32(fila["cod_navio"].ToString());
            viaje.FechaSalida = Convert.ToDateTime(fila["fecha_viaje"].ToString());
            viaje.Duracion = Convert.ToInt32(fila["duracion"].ToString());
            viaje.Itinerario = Convert.ToInt32(fila["eslora"].ToString());
            viaje.Origen = Convert.ToInt32(fila["manga"].ToString());
            viaje.Destino = Convert.ToInt32(fila["desplazamiento"].ToString());
            
            return viaje;
        }

        public int ActualizarViaje(Viaje v)
        {
            var sentenciaSql = $"UPDATE viaje SET duracion={v.Duracion}, cod_itinerario={v.Itinerario}, " +
                $"pais_origen={v.Origen}, pais_destino={v.Destino} WHERE codigo_navio={v.Cod_navio} AND fecha_viaje= '{v.FechaSalida}'";

            var filasAfectada = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);

            return filasAfectada;
        }

        public int EliminarViaje(int id, DateTime fecha)
        {
            var sentenciaSql = $"DELETE FROM viaje WHERE cod_navio={id} AND fecha_viaje= '{fecha}'";
            var filasAfectada = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);

            return filasAfectada;
        }
    }
}


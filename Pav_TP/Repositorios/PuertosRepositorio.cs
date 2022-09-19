﻿using Pav_TP.Entidades;
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
        public List<Puerto> GetPuertos()
        {
            var puertos = new List<Puerto>();
            var sentenciaSql = $"SELECT * FROM puertos";

            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var puerto = MapearPuerto(fila);
                puertos.Add(puerto);
            }

            return puertos;
        }

        public List<Puerto> GetPuertos(Puerto p)
        {
            var puertos = new List<Puerto>();
            var sentenciaSql = $"SELECT * FROM puertos WHERE nombre like '%{p.Nombre}%'";
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
            var sentenciaSql = $"SELECT * FROM puertos WHERE cod_puerto={id}";
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
            var sentenciaSql = $"DELETE FROM puertos WHERE cod_puerto={id}";
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

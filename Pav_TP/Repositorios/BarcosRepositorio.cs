using Pav_TP.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Repositorios
{
    public class BarcosRepositorio
    {
        public List<Barco> GetBarcos()
        {
            var barcos = new List<Barco>();
            var sentenciaSql = $"SELECT * FROM navio WHERE esDadoBaja is null";
            
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach(DataRow fila in tablaResultado.Rows)
            {
                var barco = MapearBarco(fila);
                barcos.Add(barco);
            }

            return barcos;
        }

        public List<Barco> GetBarcos(Barco b)
        {
            var barcos = new List<Barco>();
            var sentenciaSql = $"SELECT * FROM navio WHERE nombre like '%{b.Nombre}%' AND esDadoBaja is null";
            if (b.Codigo != 0)
                sentenciaSql += $" AND codigo_navio={b.Codigo}";

            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var barco = MapearBarco(fila);
                barcos.Add(barco);
            }

            return barcos;
        }

        public Barco GetBarcos(int id)
        {
            var barco = new Barco();
            var sentenciaSql = $"SELECT * FROM navio WHERE codigo_navio={id} AND esDadoBaja is null";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                barco = MapearBarco(fila);
            }

            return barco;
        }

        public int RegistrarBarco(Barco b)
        {
            var sentenciaSql = $"INSERT INTO navio (nombre, altura, eslora, manga, desplazamiento, autonomia, cant_camarotes, cant_max_pasajeros, cant_motores, cant_tripulantes, clasificacion) VALUES ('{b.Nombre}', {b.Altura}, {b.Eslora}, {b.Manga}, {b.Desplazamiento}, {b.Autonomia}, {b.CantCamarote}, {b.CantMaxPasajeros}, {b.CantMotores}, {b.CantTripulante}, {b.Clasificacion})";
            var filasAfectada = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);

            return filasAfectada;
        }

        private Barco MapearBarco(DataRow fila)
        {
            var barco = new Barco();
            barco.Codigo = Convert.ToInt32(fila["codigo_navio"].ToString());
            barco.Nombre = fila["nombre"].ToString();
            barco.Altura = Convert.ToInt32(fila["altura"].ToString());
            barco.Eslora = Convert.ToInt32(fila["eslora"].ToString());
            barco.Manga = Convert.ToInt32(fila["manga"].ToString());
            barco.Desplazamiento = Convert.ToInt32(fila["desplazamiento"].ToString());
            barco.Autonomia = Convert.ToInt32(fila["autonomia"].ToString());
            barco.CantCamarote = Convert.ToInt32(fila["cant_camarotes"].ToString());
            barco.CantMaxPasajeros = Convert.ToInt32(fila["cant_max_pasajeros"].ToString());
            barco.CantMotores = Convert.ToInt32(fila["cant_motores"].ToString());
            barco.CantTripulante = Convert.ToInt32(fila["cant_tripulantes"].ToString());
            barco.Clasificacion = Convert.ToInt32(fila["clasificacion"].ToString());

            return barco;
        } 

        public int ActualizarBarco(Barco b)
        {
            var sentenciaSql = $"UPDATE navio SET nombre='{b.Nombre}', altura={b.Altura}, eslora={b.Eslora}, manga={b.Manga}, " +
                $"desplazamiento={b.Desplazamiento}, autonomia={b.Autonomia}, cant_camarotes={b.CantCamarote}, " +
                $"cant_max_pasajeros={b.CantMaxPasajeros}, cant_motores={b.CantMotores}, cant_tripulantes={b.CantTripulante}, " +
                $"clasificacion={b.Clasificacion} WHERE codigo_navio={b.Codigo}";

            var filasAfectada = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);

            return filasAfectada;
        }

        public int EliminarBarco(int id)
        {
            var sentenciaSql = $"UPDATE navio set esDadoBaja=1 WHERE codigo_navio={id}";
            var filasAfectada = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);

            return filasAfectada;
        }
    }
}

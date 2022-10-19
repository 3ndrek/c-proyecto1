using Pav_TP.Entidades;
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
            var sentenciaSql = $"SELECT * FROM viaje WHERE cod_navio = {v.Cod_navio}";

            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var viaje = Mapear(fila);
                viajes.Add(viaje);
            }

            return viajes;
        }

        public List<Viaje> GetViajes(Entidades.Itinerario i)
        {
            var viajes = new List<Viaje>();
            var sentenciaSql = $"SELECT * FROM viaje WHERE cod_itinerario = {i.Cod_Itinerario}";

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
                var itinerario = new Itinerario();
                itinerario.Cod_Itinerario = Convert.ToInt32(fila["cod_itinerario"]);
                itinerario.Categoria = Convert.ToInt32(fila["categoria"]);
                itinerario.Descripcion = fila["nombre"].ToString();

                itinerarios.Add(itinerario);
            }

            return itinerarios;
        }

        public List<Barco> ObtenerBarcos()
        {
            var barcos = new List<Barco>();
            var sentenciaSql = $"SELECT * FROM navio";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var barco = new Barco();
                barco.Codigo = Convert.ToInt32(fila["codigo_navio"]);
                barco.Nombre = fila["nombre"].ToString();
                barco.Altura = Convert.ToInt32(fila["altura"]);
                barco.Eslora = Convert.ToInt32(fila["eslora"]);
                barco.Manga = Convert.ToInt32(fila["manga"]);
                barco.Desplazamiento = Convert.ToInt32(fila["desplazamiento"]);
                barco.Autonomia = Convert.ToInt32(fila["autonomia"]);
                barco.CantCamarote = Convert.ToInt32(fila["cant_camarotes"]);
                barco.CantMaxPasajeros = Convert.ToInt32(fila["cant_max_pasajeros"]);
                barco.CantMotores = Convert.ToInt32(fila["cant_motores"]);
                barco.CantTripulante = Convert.ToInt32(fila["cant_tripulantes"]);
                barco.Clasificacion = Convert.ToInt32(fila["clasificacion"]);

                barcos.Add(barco);
            }

            return barcos;
        }


        public int RegistrarViaje(Viaje v)
        {
            var sentenciaSql = $"INSERT INTO viaje (cod_navio, fecha_viaje, duracion, cod_itinerario) VALUES ({v.Cod_navio}, '{v.FechaSalida}', {v.Duracion}, {v.Itinerario})";
            var filasAfectada = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);

            return filasAfectada;
        }

        private Viaje Mapear(DataRow fila)
        {
            var viaje = new Viaje();
            viaje.Cod_navio = Convert.ToInt32(fila["cod_navio"].ToString());
            viaje.FechaSalida = Convert.ToDateTime(fila["fecha_viaje"].ToString());
            viaje.Duracion = Convert.ToInt32(fila["duracion"].ToString());
            viaje.Itinerario = Convert.ToInt32(fila["cod_itinerario"].ToString());
            return viaje;
        }

        public int ActualizarViaje(Viaje v)
        {
            var sentenciaSql = $"UPDATE viaje SET duracion={v.Duracion}, cod_itinerario={v.Itinerario} WHERE codigo_navio={v.Cod_navio} AND fecha_viaje= '{v.FechaSalida}'";

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


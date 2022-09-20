using Pav_TP.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Repositorios
{
     public class PasajerosRepositorio
    {
        public List<Pasajero> GetPasajeros()
        {
            var pasajeros = new List<Pasajero>();
            var sentenciaSql = $"SELECT * FROM pasajeros";

            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var pasajero = MapearPasajero(fila);
                pasajeros.Add(pasajero);
            }

            return pasajeros;
        }

        public List<Pasajero> GetPasajeros(Pasajero p)
        {
            var pasajeros = new List<Pasajero>();
            var sentenciaSql = $"SELECT * FROM pasajeros";
            if (p.num_doc != 0)
                sentenciaSql += $" WHERE num_doc={p.num_doc}";

            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var pasajero = MapearPasajero(fila);
                pasajeros.Add(pasajero);
            }

            return pasajeros;
        }

        public Pasajero GetPasajeros(int id)
        {
            var pasajero = new Pasajero();
            var sentenciaSql = $"SELECT * FROM pasajeros WHERE dni = {id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                pasajero = MapearPasajero(fila);
            }

            return pasajero;
        }

        public int RegistrarPasajero(Pasajero p)
        {
            var sentenciaSql = $"INSERT INTO pasajeros (tipo_doc, num_doc, nombre, apellido, ciudad_procedente, pais_procedente, email, fechaNac, genero) VALUES ({p.tipo_doc}, {p.num_doc}, '{p.nombre}', '{p.apellido}', {p.ciudad_procedente}, {p.pais_procedente}, '{p.email}', '{p.fechaNac}', {p.genero})";
            var filasAfectada = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);

            return filasAfectada;
        }

        private Pasajero MapearPasajero(DataRow fila)
        {
            var pasajero = new Pasajero();
            pasajero.tipo_doc = Convert.ToInt32(fila["tipo_doc"].ToString());
            pasajero.num_doc = Convert.ToInt32(fila["num_doc"].ToString());
            pasajero.nombre = fila["nombre"].ToString();
            pasajero.apellido = fila["apellido"].ToString();
            pasajero.ciudad_procedente = Convert.ToInt32(fila["ciudad_procedente"].ToString());
            pasajero.pais_procedente = Convert.ToInt32(fila["pais_procedente"].ToString());
            pasajero.email = fila["email"].ToString();
            pasajero.fechaNac = Convert.ToDateTime(fila["fechaNac"].ToString());
            pasajero.genero = Convert.ToInt32(fila["genero"].ToString());


            return pasajero;
        }
        public int ActualizarPasajero(Pasajero p)
        {
            var sentenciaSql = $"UPDATE pasajeros SET nombre ='{p.nombre}', apellido ='{p.apellido}', " +
                $"ciudad_procedente= {p.ciudad_procedente}, pais_procedente = {p.pais_procedente}, email= '{p.email}', fechaNac ='{p.fechaNac}', genero ={p.genero} WHERE tipo_doc={p.tipo_doc} AND num_doc={p.num_doc}";

            var filasAfectada = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);

            return filasAfectada;
        }

        public int EliminarPasajero(int id)
        {
            var sentenciaSql = $"DELETE FROM pasajeros WHERE num_doc ={id}";
            var filasAfectada = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);

            return filasAfectada;
        }
    }
}

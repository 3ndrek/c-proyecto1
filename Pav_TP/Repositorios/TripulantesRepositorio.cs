using Pav_TP.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Repositorios
{
    public class TripulantesRepositorio
    {
        public List<Tripulante> GetTripulantes()
        {
            var tripulantes = new List<Tripulante>();
            var sentenciaSql = $"SELECT * FROM tripulantes WHERE esDadoBaja is null";

            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var tripu = MapearTripulante(fila);
                tripulantes.Add(tripu);
            }

            return tripulantes;
        }

        public List<Tripulante> GetTripulantes(Tripulante t)
        {
            var tripulantes = new List<Tripulante>();
            var sentenciaSql = $"SELECT * FROM tripulantes WHERE esDadoBaja is null";
            if (t.legajo != 0)
                sentenciaSql += $" AND legajo={t.legajo}";

            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var tripulacion = MapearTripulante(fila);
                tripulantes.Add(tripulacion);
            }

            return tripulantes;
        }

        public Tripulante GetTripulantes(int id)
        {
            var tripulante = new Tripulante();
            var sentenciaSql = $"SELECT * FROM tripulantes WHERE legajo = {id} AND esDadoBaja is null";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                tripulante = MapearTripulante(fila);
            }

            return tripulante;
        }

        public int RegistrarTripulantet(Tripulante t)
        {
            var sentenciaSql = $"INSERT INTO tripulantes ( jefe, nombre, apellido, email, fechaNac, puesto) VALUES ( {t.jefe}, '{t.nombre}', '{t.apellido}', '{t.email}', '{t.fechaNac}', {t.puesto})";
            var filasAfectada = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);

            return filasAfectada;
        }

        private Tripulante MapearTripulante(DataRow fila)
        {
            var tripulante = new Tripulante();
            tripulante.legajo = Convert.ToInt32(fila["legajo"].ToString());
            tripulante.jefe = Convert.ToInt32(fila["jefe"].ToString());
            tripulante.nombre = fila["nombre"].ToString();
            tripulante.apellido = fila["apellido"].ToString();
            tripulante.email = fila["email"].ToString();
            tripulante.fechaNac = Convert.ToDateTime(fila["fechaNac"].ToString());
            tripulante.puesto = Convert.ToInt32(fila["puesto"].ToString());
            

            return tripulante;
        }

        public int ActualizarTripulante(Tripulante t)
        {
            var sentenciaSql = $"UPDATE tripulantes SET jefe ={t.jefe}, nombre ='{t.nombre}', apellido ='{t.apellido}', " +
                $"puesto ={t.puesto} WHERE legajo={t.legajo} ";


            var filasAfectada = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);

            return filasAfectada;
        }

        public int EliminarTripulante(int id)
        {
            var sentenciaSql = $"UPDATE tripulantes set esDadoBaja=1 WHERE legajo ={id}";
            var filasAfectada = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);

            return filasAfectada;
        }
    }
}

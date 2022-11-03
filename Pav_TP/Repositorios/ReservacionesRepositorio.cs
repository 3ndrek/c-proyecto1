using Pav_TP.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Repositorios
{
    public class ReservacionesRepositorio
    {
        private pasajeroXreserva pasajeroXreserv;

        public ReservacionesRepositorio()
        {
            pasajeroXreserv = new pasajeroXreserva();
        }

        public List<Reservaciones> GetReservaciones()
        {
            var reservas = new List<Reservaciones>();
            var sentenciaSql = $"SELECT * FROM reservaciones WHERE esDadoBaja is null";

            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var reserva = Mapear(fila);
                reservas.Add(reserva);
            }

            return reservas;
        }
        public List<Reservaciones> GetReservaciones(Reservaciones r)
        {
            var reservas = new List<Reservaciones>();
            var sentenciaSql = $"SELECT * FROM reservaciones WHERE nro_reservacion = {r.num_reservacion} AND esDadoBaja is null";

            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var reserva = Mapear(fila);
                reservas.Add(reserva);
            }

            return reservas;
        }
        private Reservaciones Mapear(DataRow fila)
        {
            var reserva = new Reservaciones();
            reserva.cod_navio = Convert.ToInt32(fila["cod_navio"].ToString());
            reserva.num_cubierta = Convert.ToInt32(fila["num_cubierta"].ToString());
            reserva.num_camarote = Convert.ToInt32(fila["num_camarotes"].ToString());
            reserva.fecha_viaje = Convert.ToDateTime(fila["fecha_viaje"].ToString());
            reserva.cama_ocupada = Convert.ToInt32(fila["cama_ocupada"].ToString());
            reserva.tipo_doc = Convert.ToInt32(fila["tipo_doc"].ToString());
            reserva.num_doc = Convert.ToInt32(fila["num_doc"].ToString());
            reserva.monto = Convert.ToInt32(fila["PrecioReserva"].ToString());
            reserva.num_reservacion = Convert.ToInt32(fila["nro_reservacion"].ToString());
            return reserva;
        }

        public void EliminarReserva(int id, int num, DateTime fecha, int cubierta, int navio)
        {
            var sentenciaSql = $"UPDATE reservaciones set esDadoBaja=1 WHERE nro_reservacion={id}";

            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var sql2 = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);

                    var CCxVV = $" DELETE FROM camarotesXviajes WHERE num_camarote={num} AND num_cubierta= {cubierta} AND fecha_viaje= '{fecha}' AND cod_navio= {navio} ";
                    DBHelper.GetDBHelper().EjecutarSQL(CCxVV);
                    tx.Commit();
                }

                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new ApplicationException("hubo un problema al eliminar la reserva");
                }

                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
                
            }

        }

        public List<Itinerario> GetItinerarios()
        {
            var sql = "SELECT * from itinerarios WHERE esDadoBaja is null";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var itne = new List<Itinerario>();

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var itinerario = new Itinerario();
                itinerario.Cod_Itinerario = Convert.ToInt32(fila["cod_itinerario"]);
                itinerario.Categoria = Convert.ToInt32(fila["categoria"]);
                itinerario.Descripcion = fila["nombre"].ToString();

                itne.Add(itinerario);
            }
            return itne;
        }

        public void CargarReserva(Reservaciones r)
        {
            var sql = $"insert into reservaciones (cod_navio,num_cubierta,num_camarotes,fecha_viaje,cama_ocupada,tipo_doc,num_doc,PrecioReserva)" +
                $" values ({r.cod_navio},{r.num_cubierta},{r.num_camarote},'{r.fecha_viaje}',{r.cama_ocupada},{r.tipo_doc},{r.num_doc},{r.monto} )";

            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var num= DBHelper.GetDBHelper().EjecutarTransaccionSQL(sql);

                    var PPxRR = $" INSERT INTO pasajeroXreservaciones (tipo_doc, num_doc,nro_reserva) " +
                        $" VALUES ({r.tipo_doc},{r.num_doc},{num}) ";
                    DBHelper.GetDBHelper().EjecutarTransaccionSQL(PPxRR);

                    var camarotesXviajes = $"INSERT INTO camarotesXviajes (cod_navio, num_cubierta,num_camarote,fecha_viaje,ocupacion)" +
                        $" VALUES ({r.cod_navio},{r.num_cubierta},{r.num_camarote},'{r.fecha_viaje}', 1 )";

                    DBHelper.GetDBHelper().EjecutarTransaccionSQL(camarotesXviajes);
                    tx.Commit();
                }

                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new ApplicationException("hubo un problema al registrar la reserva");
                }

                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }
        }
    }
}

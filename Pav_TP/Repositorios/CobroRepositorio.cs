using Pav_TP.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Repositorios
{
    internal class CobroRepositorio
    {

        public List<Reservaciones> Getreservaciones(Pasajero pasajeroFiltro)
        {
            var Reservacion = new List<Reservaciones>();

            var sql = $"select pr.* , r.cod_navio,r.num_cubierta,r.num_camarotes, r.fecha_viaje, r.cama_ocupada from pasajeroXreservaciones pr join reservaciones r on r.nro_reservacion = pr.nro_reserva and pr.tipo_doc={pasajeroFiltro.tipo_doc} and pr.num_doc={pasajeroFiltro.num_doc}";

            // join de pasajerosXreservaciones para traer el estado de reservacion 

            var tablaReservaciones = DBHelper.GetDBHelper().ConsultaSQL(sql);

            foreach (DataRow fila in tablaReservaciones.Rows)
            {
                var reservacionFiltrada = new Reservaciones();
                reservacionFiltrada.estado_reserva = fila["estado_reserva"].ToString();
                reservacionFiltrada.cama_ocupada = Convert.ToInt32(fila["cama_ocupada"].ToString());
                reservacionFiltrada.num_reservacion = Convert.ToInt32(fila["nro_reserva"]);
                reservacionFiltrada.fecha_viaje = Convert.ToDateTime(fila["fecha_viaje"]);
                reservacionFiltrada.num_cubierta = Convert.ToInt32(fila["num_cubierta"]);
                reservacionFiltrada.cod_navio = Convert.ToInt32(fila["cod_navio"]);
                reservacionFiltrada.num_camarote = Convert.ToInt32(fila["num_camarotes"]);

                Reservacion.Add(reservacionFiltrada);
            }

            return Reservacion;
        }


        public List<Modo_pago> GetModo_Pagos()
        {
            var modoPagoX = new List<Modo_pago>();
            var sql = $"select * from Modospagos";

            var tablasModos = DBHelper.GetDBHelper().ConsultaSQL(sql);

            foreach (DataRow fila in tablasModos.Rows)
            {
                var modoTraido = new Modo_pago();
                modoTraido.modo_pago = Convert.ToInt32(fila["modo_pago"]);
                modoTraido.descripcion = fila["descripcion"].ToString();

                modoPagoX.Add(modoTraido);
            }
            return modoPagoX;
        }

        public List<TipoDoc> GetTiposDocs()
        {
            var GetsTipos = new List<TipoDoc>();
            var sql = $"select * from tipo_doc";

            var tablasTipos = DBHelper.GetDBHelper().ConsultaSQL(sql);

            foreach (DataRow fila in tablasTipos.Rows)
            {
                var tipoTraido = new TipoDoc();
                tipoTraido.tipo = Convert.ToInt32(fila["tipo"]);
                tipoTraido.desc = fila["descripcion"].ToString();

                GetsTipos.Add(tipoTraido);
            }

            return GetsTipos;
        }

        public List<Pasajero> GetPasajeros(Pasajero pasajero)
        {
            var getPasajeros = new List<Pasajero>();
            var sql = $"select * from pasajeros where 1=1 and tipo_doc = {pasajero.tipo_doc} and num_doc = {pasajero.num_doc} "; 

            var tablasPasajeros = DBHelper.GetDBHelper().ConsultaSQL(sql);

            foreach (DataRow fila in tablasPasajeros.Rows)
            {
                var PasajeroTraido = new Pasajero();
                PasajeroTraido.nombre = fila["nombre"].ToString();
                PasajeroTraido.apellido = fila["apellido"].ToString();

                getPasajeros.Add(PasajeroTraido);
            }

            return getPasajeros;
        }


       public void RegistrarCobroReserva( pasajeroXreserva pasajeroXreserva1 )
        {
            var sql =$" INSERT INTO cobros (nro_reserva, modo_pago, monto, fecha_pago) VALUES ({pasajeroXreserva1.cobros.nro_reserva},{pasajeroXreserva1.cobros.modo_pago},{pasajeroXreserva1.cobros.monto}, '{pasajeroXreserva1.cobros.fecha_pago}' )";

            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    DBHelper.GetDBHelper().EjecutarTransaccionSQL(sql);

                    var sqlReservas = $"UPDATE pasajeroXreservaciones SET estado_reserva= '{pasajeroXreserva1.estado_reserva}' where nro_reserva = {pasajeroXreserva1.cobros.nro_reserva}";
                    DBHelper.GetDBHelper().EjecutarTransaccionSQL(sqlReservas);
                    tx.Commit();
                }
                catch (Exception ex)
                {
                    tx.Rollback();

                    throw new ApplicationException("hubo un problema al registrar el cobro ");
                }


            }

        }

    }
}

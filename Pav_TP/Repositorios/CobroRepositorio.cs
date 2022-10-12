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

        public List<Reservaciones> Getreservaciones()
        {
            var Reservacion = new List<Reservaciones>();

            var sql = " select R.cod_navio, R.num_cubierta,R.num_camarotes,R.fecha_viaje,R.cama_ocupada,R.cama_ocupada, R.tipo_doc, R.num_doc, R.nro_reservacion, p.nombre, p.apellido " +
            "from reservaciones R join pasajeros P ON p.tipo_doc = r.tipo_doc and p.num_doc = r.num_doc ";

            // join de pasajerosXreservaciones para traer el estado de reservacion 

            var tablaReservaciones = DBHelper.GetDBHelper().ConsultaSQL(sql);

            foreach (DataRow fila in tablaReservaciones.Rows )
            {
                var reservacionFiltrada = new Reservaciones();
                reservacionFiltrada.cama_ocupada = Convert.ToInt32(fila["cama_ocupada"].ToString());
                reservacionFiltrada.num_reservacion = Convert.ToInt32(fila["nro_reservacion"]);
                reservacionFiltrada.fecha_viaje = Convert.ToDateTime(fila["fecha_viaje"]);
                reservacionFiltrada.num_cubierta = Convert.ToInt32(fila["num_cubierta"]);
                reservacionFiltrada.cod_navio = Convert.ToInt32(fila["cod_navio"]);
                reservacionFiltrada.num_camarote = Convert.ToInt32(fila["num_camarotes"]);
                reservacionFiltrada.tipo_doc = Convert.ToInt32(fila["tipo_doc"]);
                reservacionFiltrada.num_doc = Convert.ToInt32(fila["num_doc"]);

                Reservacion.Add(reservacionFiltrada);
            }

            return Reservacion ; 
        }


        public List<Modo_pago> GetModo_Pagos()
        {
            var modoPagoX = new List<Modo_pago>();
            var sql = "select * from Modospagos";

            var tablasModos = DBHelper.GetDBHelper().ConsultaSQL(sql);

            foreach (DataRow fila in tablasModos.Rows )
            {
                var modoTraido = new Modo_pago();
                modoTraido.modo_pago = Convert.ToInt32(fila["modo_pago"]);
                modoTraido.descripcion = fila["descripcion"].ToString();

                modoPagoX.Add(modoTraido);
            }
            return modoPagoX;
        }

        public List<tiposDoc> GetTiposDocs()
        {
            var GetsTipos = new List<tiposDoc>();
            var sql = "select * from tipo_doc";

            var tablasTipos = DBHelper.GetDBHelper().ConsultaSQL(sql);

            foreach  (DataRow fila in tablasTipos.Rows )
            {
                var tipoTraido = new tiposDoc();
                tipoTraido.tipo = Convert.ToInt32(fila["tipo"]);
                tipoTraido.descripcion = fila["descripcion"].ToString();

                GetsTipos.Add(tipoTraido);
            }

            return GetsTipos;

        }
    }
}

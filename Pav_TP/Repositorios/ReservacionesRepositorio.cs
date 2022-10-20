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



        public List<Itinerario> GetItinerarios()
        {
            var sql = "SELECT * from itinerarios";
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
                    throw new ApplicationException("hubo un problema al registrar el cobro");
                }

                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }

            }
        }
    }
}

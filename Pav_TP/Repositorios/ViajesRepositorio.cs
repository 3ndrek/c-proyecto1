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
        public void RegistrarViaje(Viaje v)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var sql = "INSERT INTO viajes (CodigoNav, Fecha_Viaje, Duracion, Cod_itinerario, pais_origen, pais_destino";
                    sql += $" VALUES('{v.Cod_navio}'";
                    sql += $", '{v.FechaSalida.ToString("yyyy-MM-dd")}', {v.Duracion}, {v.Itinerario}, {v.Origen}, {v.Destino}";
                    sql += ")";

                    DBHelper.GetDBHelper().EjecutarTransaccionSQL(sql);
                    tx.Commit();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new ApplicationException("Hubo un problema al registrar. Intente nuevamente");

                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }
        }
   
    }
}

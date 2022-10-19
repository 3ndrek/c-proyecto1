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

        }
    }
}

using Pav_TP.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Repositorios
{
    public class PuertosRepositorio
    {
        public List<Puertos> GetPuertos(Itinerario itinerario)
        {
            var puertos = new List<Puertos>();
            var sentenciaSql = $"SELECT P.* FROM puertos P JOIN puertoXitinerarios PxI ON P.cod_puerto= PxI.cod_puerto JOIN itinerarios I ON PxI.cod_itinerarios = I.cod_itinerario WHERE I.cod_itinerario = {itinerario.Cod_Itinerario}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);

            foreach (DataRow fila in tablaResultado.Rows)
            {
                var puerto = new Puertos();
                puerto.cod_puerto = Convert.ToInt32(fila["cod_puerto"]);
                puerto.nombre = fila["nombre"].ToString();

                puertos.Add(puerto);
            }

            return puertos;

        }
    }
}

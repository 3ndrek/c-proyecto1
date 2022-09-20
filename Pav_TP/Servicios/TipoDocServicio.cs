using Pav_TP.Entidades;
using Pav_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Servicios
{
    public class TipoDocServicio
    {
        private TipoDocRepositorio tipoRepositorio;

        public TipoDocServicio()
        {
            tipoRepositorio = new TipoDocRepositorio();
        }

        public List<TipoDoc> GetTipos()
        {
            return tipoRepositorio.GetTipos();
        }
    }
}

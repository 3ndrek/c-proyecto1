using Pav_TP.Entidades;
using Pav_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Servicios
{
    public class PerfilesServicio
    {
        private readonly PerfilesRespositorio perfilesRespositorio;
        private object prefilesRespositorio;

        public PerfilesServicio()
        {
            perfilesRespositorio = new PerfilesRespositorio();
        }
        public List<Perfil> getPerfiles()
        {
            return PerfilesRespositorio.Get;
        }

        private class PerfilesRespositorio
        {
            public static List<Perfil> Get { get; internal set; }
        }
    }
}

using Pav_TP.Entidades;
using Pav_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Servicios
{
    public class CubiertasServicio
    {
        private readonly CubiertasRepositorio cubiertasRepositorio;

        public CubiertasServicio()
        {
            cubiertasRepositorio = new CubiertasRepositorio();
        }

        public List<Cubierta> GetCubiertas(Barco filtros)
        {
            return cubiertasRepositorio.GetCubiertas(filtros);
        }
        public List<Cubierta> GetCubiertas(Cubierta filtros)
        {
            return cubiertasRepositorio.GetCubiertas(filtros);
        }

        public List<Barco> GetBarcos()
        {
            return cubiertasRepositorio.GetBarcos();
        }
    }
}

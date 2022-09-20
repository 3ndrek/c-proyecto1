﻿using Pav_TP.Entidades;
using Pav_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Servicios
{
    public class PaisesServicios
    {
        private PaisesRepositorio paisRepositorio;

        public PaisesServicios()
        {
            paisRepositorio = new PaisesRepositorio();
        }

        public List<Paises> GetPaises()
        {
            return paisRepositorio.GetPaises();
        }
    }
}

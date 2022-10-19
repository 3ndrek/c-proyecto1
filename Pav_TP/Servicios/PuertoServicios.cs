﻿using Pav_TP.Entidades;
using Pav_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Servicios
{
    public class PuertoServicios
    {
        private PuertosRepositorio puertosRepositorio;

        public PuertoServicios()
        {
            puertosRepositorio = new PuertosRepositorio();
        }

        public List<Puertos> GetPuertos(Entidades.Itinerario itinerario)
        {
            return puertosRepositorio.GetPuertos(itinerario);
        }
    }
}

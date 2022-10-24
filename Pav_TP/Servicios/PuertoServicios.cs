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


        public List<Puerto> GetPuertos()
        {
            return puertosRepositorio.GetPuertos();
        }
        public List<Puerto> GetPuertos(Puerto puerto)
        {
            return puertosRepositorio.GetPuertos(puerto);
        }

        public Puerto GetPuertos(int id)
        {
            return puertosRepositorio.GetPuertos(id);
        }

        public void EliminarPuerto(int id)
        {
            var filasAfectadas = puertosRepositorio.EliminarPuerto(id);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al eliminar");
        }

        public void ValidarPuerto(Puerto puerto)
        {
            puerto.ValidarNombre();
        }

        public bool RegistrarPuerto(Puerto puerto)
        {
            var filasAfectadas = puertosRepositorio.RegistrarPuerto(puerto);
            if (filasAfectadas == 1)
                return true;

            return false;
        }

        public void ActualizarPuerto(Puerto puerto)
        {
            var filasAfectadas = puertosRepositorio.ActualizarPuerto(puerto);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }

    }
}

using Pav_TP.Entidades;
using Pav_TP.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Servicios
{
    public class ViajesServicios
    {
        private readonly ViajesRepositorio repositorio;

        public ViajesServicios()
        {
            repositorio = new ViajesRepositorio();
        }

        public void Validar(Viaje viaje)
        {
            viaje.ValidarCodigo();
            viaje.ValidarDestino();
            viaje.ValidarDuracion();
            viaje.ValidarFecha();
            viaje.ValidarItininerario();
            viaje.ValidarOrigen();
        }

        public Viaje GetViaje(long id)
        {
            return repositorio.GetViaje(id);
        }
    }
}

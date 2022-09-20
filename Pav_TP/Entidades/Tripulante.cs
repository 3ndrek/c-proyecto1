using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Entidades
{
    public class Tripulante
    {
        public int legajo { get; set; }
        public int jefe { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public DateTime fechaNac { get; set; }
        public int puesto { get; set; }

       
        public void ValidarJefe()
        {
            if (string.IsNullOrEmpty(this.jefe.ToString()) && this.jefe<= 0)
                crearException("Este campo es requerido.");
        }

        public void ValidarNombre()
        {
            if (string.IsNullOrEmpty(this.nombre))
                crearException("Este campo es requerido.");
        }

        public void ValidarApellido()
        {
            if (string.IsNullOrEmpty(this.apellido))
                crearException("Este campo es requerido.");
        }

        public void ValidarEmail()
        {
            if (string.IsNullOrEmpty(this.email))
                crearException("Este campo es requerido.");
        }

        public void ValidarPuesto()
        {
            if (string.IsNullOrEmpty(this.puesto.ToString()) && this.puesto< 0)
                crearException("El nombre del barco es requerido.");
        }

       
        public ApplicationException crearException(string mensaje)
        {
            return new ApplicationException(mensaje);
        }
    }


}

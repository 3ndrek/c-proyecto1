using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Entidades
{
    public class Pasajero
    {
        public int tipo_doc { get; set; }
        public int num_doc { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int ciudad_procedente { get; set; }
        public int pais_procedente { get; set; }
        public string email { get; set; }
        public DateTime fechaNac { get; set; }
        public int genero { get; set; }

        public void ValidarTipoDoc()
        {
            if (string.IsNullOrEmpty(this.tipo_doc.ToString()) && this.tipo_doc < 0)
                crearException("Este campo es requerido.");
        }

        public void ValidarNumDoc()
        {
            if (string.IsNullOrEmpty(this.num_doc.ToString()) && this.num_doc < 0)
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

        public void ValidarCiudad()
        {
            if (string.IsNullOrEmpty(this.ciudad_procedente.ToString()) && this.ciudad_procedente < 0)
                crearException("Este campo es requerido.");
        }

        public void ValidarPais()
        {
            if (string.IsNullOrEmpty(this.pais_procedente.ToString()) && this.pais_procedente < 0)
                crearException("Este campo es requerido.");
        }



        public void ValidarEmail()
        {
            if (string.IsNullOrEmpty(this.email))
                crearException("Este campo es requerido.");
        }

        public void ValidarGenero()
        {
            if (string.IsNullOrEmpty(this.genero.ToString()) && this.genero < 0)
                crearException("El nombre del barco es requerido.");
        }


        public ApplicationException crearException(string mensaje)
        {
            return new ApplicationException(mensaje);
        }

    }
}

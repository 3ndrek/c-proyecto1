using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Entidades
{
    public class Barco
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Altura { get; set; }
        public int Eslora { get; set; }
        public int Manga { get; set; }
        public int Desplazamiento { get; set; }
        public int Autonomia { get; set; }
        public int CantCamarote { get; set; }
        public int CantMaxPasajeros { get; set; }
        public int CantMotores { get; set; }
        public int CantTripulante { get; set; }
        public int Clasificacion { get; set; }

        public void ValidarNombre()
        {
            if(string.IsNullOrEmpty(this.Nombre))
                crearException("El nombre del barco es requerido.");
            if (!string.IsNullOrEmpty(Nombre) && Nombre.Length > 10)
                crearException("El nombre del barco no debe superar los 10 caracteres.");
        }

        public void ValidarAltura()
        {
            if (string.IsNullOrEmpty(this.Altura.ToString()) && this.Altura < 0)
                crearException("La Altura del barco es requerido.");
        }

        public void ValidarManga()
        {
            if (string.IsNullOrEmpty(this.Manga.ToString()) && this.Manga < 0)
                crearException("El nombre del barco es requerido.");
        }

        public void ValidarDesplazamiento()
        {
            if (string.IsNullOrEmpty(this.Manga.ToString()) && this.Desplazamiento < 0)
                crearException("El nombre del barco es requerido.");
        }

        public void ValidarAutonomia()
        {
            if (string.IsNullOrEmpty(this.Manga.ToString()) && this.Autonomia < 0)
                crearException("El nombre del barco es requerido.");
        }

        public void ValidarCamarotes()
        {
            if (string.IsNullOrEmpty(this.Manga.ToString()) && this.CantCamarote < 0)
                crearException("El nombre del barco es requerido.");
        }

        public void ValidarPasajeros()
        {
            if (string.IsNullOrEmpty(this.Manga.ToString()) && this.CantMaxPasajeros < 0)
                crearException("El nombre del barco es requerido.");
        }

        public void ValidarMotores()
        {
            if (string.IsNullOrEmpty(this.Manga.ToString()) && this.CantMotores < 0)
                crearException("El nombre del barco es requerido.");
        }

        public void ValidarTripulacion()
        {
            if (string.IsNullOrEmpty(this.Manga.ToString()) && this.CantTripulante < 0)
                crearException("El nombre del barco es requerido.");
        }

        public void ValidarClasificacion()
        {
            if (string.IsNullOrEmpty(this.Manga.ToString()))
                crearException("El nombre del barco es requerido.");
        }

        public ApplicationException crearException(string mensaje)
        {
            return new ApplicationException(mensaje);
        }

    }
}

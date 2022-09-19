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
            if (string.IsNullOrEmpty(this.Nombre))
                crearException("El nombre del barco es requerido.");
            if (!string.IsNullOrEmpty(Nombre) && Nombre.Length > 10)
                crearException("El nombre");
        }

        public void ValidarAltura()
        {
            if (this.Altura < 0)
                crearException("La altura");
        }

        public void ValidarManga()
        {
            if (this.Manga < 0)
                crearException("La manga");
        }

        public void ValidarDesplazamiento()
        {
            if (this.Desplazamiento < 0)
                crearException("El desplazamiento");
        }

        public void ValidarAutonomia()
        {
            if (this.Autonomia < 0)
                crearException("La autonomía");
        }

        public void ValidarCamarotes()
        {
            if (this.CantCamarote < 0)
                crearException("La cantidad de camarotes");
        }

        public void ValidarPasajeros()
        {
            if (this.CantMaxPasajeros < 0)
                crearException("La cantidad máxima de pasajeros");
        }

        public void ValidarMotores()
        {
            if (this.CantMotores < 0)
                crearException("La cantidad de motores");
        }

        public void ValidarTripulacion()
        {
            if (this.CantTripulante < 0)
                crearException("La cantidad de tripulantes");

        }

        public void ValidarClasificacion()
        {
            if (this.Clasificacion == 0)
                crearException("La clasificación");
        }

        public ApplicationException crearException(string mensaje)
        {
            throw new ApplicationException($"{mensaje} del barco incorrecta, intentenlo nuevamente.");
        }

    }
}

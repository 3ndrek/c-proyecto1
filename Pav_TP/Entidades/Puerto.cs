using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Entidades
{
    public class Puerto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }


        public void ValidarNombre()
        {
            if (string.IsNullOrEmpty(this.Nombre))
                throw new ApplicationException("El nombre del puerto es requerido.");
            if (!string.IsNullOrEmpty(Nombre) && Nombre.Length > 10)
                throw new ApplicationException("El nombre del puerto no debe superar los 10 caracteres.");
        }

    }
}

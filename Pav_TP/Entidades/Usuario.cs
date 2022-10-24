using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Entidades
{
    public class Usuario
    {
        private long _id;

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string NombreUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string Contrasenia { get; set; }
        public string Email { get; set; }

        public bool Estado { get; set; }
        public long Perfil { get; set; }
        //public Perfil Perfil { get; set; }
    }
}

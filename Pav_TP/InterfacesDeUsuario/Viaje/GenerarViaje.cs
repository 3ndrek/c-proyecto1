using Pav_TP.Entidades;
using Pav_TP.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV1
{
    public partial class GenerarViaje : Form
    {
        private readonly PaisesServicios paisesServicios;
        private readonly ViajesServicios viajesServicios;
        //private readonly ItinerariosServicios itinerariosServicios;
        public GenerarViaje()
        {   
            InitializeComponent();
        }
    }
}

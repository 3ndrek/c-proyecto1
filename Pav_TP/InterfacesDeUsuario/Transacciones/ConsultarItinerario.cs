using Pav_TP.Entidades;
using Pav_TP.InterfacesDeUsuario.Pasajero;
using Pav_TP.Servicios;
using seastar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pav_TP.InterfacesDeUsuario.Transacciones
{
    public partial class ConsultarItinerario : Form
    {
        private ItinerarioServicios itinerarioServicios;
        private FrmPrincipal frmPrincipal;
        public ConsultarItinerario(FrmPrincipal frm)
        {
            frmPrincipal = frm;
            itinerarioServicios = new ItinerarioServicios();
            InitializeComponent();
        }

        private void ConsultarItinerario_Load(object sender, EventArgs e)
        {
            CargarItinerario();
            this.FormClosed += new FormClosedEventHandler(cerrarForm);
        }
        private void cerrarForm(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CargarItinerario()
        {
            var itinerarios = itinerarioServicios.GetItinerarios();
            DvgItinerarios.Rows.Clear();
            FuncionalidadCargarItinerarios(itinerarios);
        }
        private void CargarItinerario(Entidades.Itinerario i)
        {
            var itinerarios = itinerarioServicios.GetItinerarios(i);
            DvgItinerarios.Rows.Clear();
            FuncionalidadCargarItinerarios(itinerarios);
        }

        private void FuncionalidadCargarItinerarios(List<Entidades.Itinerario> i)
        {
            foreach (var iti in i)
            {
                var fila = new string[]
                {
                    iti.Cod_Itinerario.ToString(),
                    iti.Categoria.ToString(),
                    iti.Descripcion.ToString()
                };
                DvgItinerarios.Rows.Add(fila);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var buscar = new Entidades.Itinerario();
            if (Convert.ToInt32(TxtCod.Text.Trim()) != 0)
            {
                buscar.Cod_Itinerario = Convert.ToInt32(TxtCod.Text.Trim());
                CargarItinerario(buscar);
                return;
            }
            CargarItinerario();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal.Show();
        }
    }
}

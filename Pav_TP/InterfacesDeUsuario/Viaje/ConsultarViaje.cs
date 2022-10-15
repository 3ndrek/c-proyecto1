using Pav_TP.Entidades;
using Pav_TP.Servicios;
using PAV1;
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

namespace PAV1
{
    public partial class ConsultarViaje : Form
    {
        private ViajesServicios viajesServicios;
        private FrmPrincipal frmPrincipal;
        public ConsultarViaje(FrmPrincipal frm)
        {
            frmPrincipal = frm;
            viajesServicios = new ViajesServicios();
            InitializeComponent();
        }

        private void ConsultarViaje_Load(object sender, EventArgs e)
        {
            CargarViaje();
        }
        private void CargarViaje()
        {
            var viajes = viajesServicios.GetViajes();
            DgvViaje.Rows.Clear();
            FuncionalidadCargarViajes(viajes);
        }
        private void CargarViaje(Viaje v)
        {
            var viajes = viajesServicios.GetViajes(v);
            DgvViaje.Rows.Clear();
            FuncionalidadCargarViajes(viajes);
        }

        private void FuncionalidadCargarViajes(List<Viaje> v)
        {
            foreach (var viaje in v)
            {
                var fila = new string[]
                {
                    viaje.Cod_navio.ToString(),
                    viaje.FechaSalida.ToString(),
                    viaje.Duracion.ToString(),
                    viaje.Itinerario.ToString(),
                    viaje.Origen.ToString(),
                    viaje.Destino.ToString(),
                };
                DgvViaje.Rows.Add(fila);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GenerarViaje(frmPrincipal).Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var fecha = Convert.ToDateTime(DgvViaje.SelectedRows[0].Cells["fecha_viaje"].Value);
            var id = Convert.ToInt32(DgvViaje.SelectedRows[0].Cells["cod_navio"].Value);
            viajesServicios.EliminarViaje(id, fecha);
            DgvViaje.Rows.Clear();
            CargarViaje();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var buscar = new Viaje();
            if (Convert.ToInt32(TxtCodigo.Text.Trim()) != 0)
            {
                buscar.Cod_navio = Convert.ToInt32(TxtCodigo.Text.Trim());
                CargarViaje(buscar);
                return;
            }
            CargarViaje();
        }

        private void CerrarFormulario()
        {
            frmPrincipal.Show();
            this.Dispose();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }
    }
}

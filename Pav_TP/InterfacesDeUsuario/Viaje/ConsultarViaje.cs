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

        private void FuncionalidadCargarViajes(List<Viaje> viajes)
        {
            foreach (var viaje in viajes)
            {
                var fila = new string[]
                {
                    viaje.Cod_navio.ToString(),
                    viaje.FechaSalida.ToString(),
                    viaje.Destino.ToString(),
                    viaje.Itinerario.ToString(),
                    viaje.Origen.ToString(),
                    viaje.Destino.ToString(),
                };
                DgvViaje.Rows.Add(fila);
            }
        }
       
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new GenerarViaje(frmPrincipal).Show();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            var fecha = Convert.ToDateTime(DgvViaje.SelectedRows[0].Cells["fecha_viaje"].Value);
            var id = Convert.ToInt32(DgvViaje.SelectedRows[0].Cells["cod_navio"].Value);
            viajesServicios.EliminarViaje(id, fecha);
            DgvViaje.Rows.Clear();
            CargarViaje();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var viajeFiltro = new Viaje();
            if (Convert.ToInt32(TxtCod.Text.Trim()) != 0)
                viajeFiltro.Cod_navio = Convert.ToInt32(TxtCod.Text.Trim());
            viajeFiltro.FechaSalida = Convert.ToDateTime(dateTimePicker1.Text.Trim());
            if (Convert.ToInt32(TxtCod.Text.Trim()) != 0 || TxtCod.Text.Trim() != null)
            {
                CargarViaje(viajeFiltro);
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

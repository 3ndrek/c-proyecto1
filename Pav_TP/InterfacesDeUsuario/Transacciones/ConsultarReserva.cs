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

namespace Pav_TP.InterfacesDeUsuario.Transacciones
{
    public partial class ConsultarReserva : Form
    {
        private ReservacionesServicios reservacionesServicios;
        private FrmPrincipal frmPrincipal;
        public ConsultarReserva(FrmPrincipal frm)
        {
            frmPrincipal = frm;
            reservacionesServicios = new ReservacionesServicios();
            InitializeComponent();
        }

        private void ConsultarReserva_Load(object sender, EventArgs e)
        {
            CargarReserva();
        }
        private void CargarReserva()
        {
            var reservaciones = reservacionesServicios.GetReservaciones();
            DgvReserva.Rows.Clear();
            FuncionalidadCargarReservaciones(reservaciones);
        }
        private void CargarReserva(Reservaciones r)
        {
            var reservaciones = reservacionesServicios.GetReservaciones(r);
            DgvReserva.Rows.Clear();
            FuncionalidadCargarReservaciones(reservaciones);
        }

        private void FuncionalidadCargarReservaciones(List<Reservaciones> r)
        {
            foreach (var reserva in r)
            {
                var fila = new string[]
                {
                    reserva.cod_navio.ToString(),
                    reserva.num_cubierta.ToString(),
                    reserva.num_camarote.ToString(),
                    reserva.fecha_viaje.ToString(),
                    reserva.cama_ocupada.ToString(),
                    reserva.tipo_doc.ToString(),
                    reserva.num_doc.ToString(),
                    reserva.monto.ToString(),
                    reserva.num_reservacion.ToString(),
                };
                DgvReserva.Rows.Add(fila);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var buscar = new Reservaciones();
            if (Convert.ToInt32(TxtNumero.Text.Trim()) != 0)
            {
                buscar.num_reservacion = Convert.ToInt32(TxtNumero.Text.Trim());
                CargarReserva(buscar);
                return;
            }
            CargarReserva();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Reserva(frmPrincipal).Show();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(DgvReserva.SelectedRows[0].Cells["nro_reservacion"].Value);
            var num = Convert.ToInt32(DgvReserva.SelectedRows[0].Cells["num_camarote"].Value);
            var fecha = Convert.ToDateTime(DgvReserva.SelectedRows[0].Cells["fecha_viaje"].Value);
            var cubierta = Convert.ToInt32(DgvReserva.SelectedRows[0].Cells["num_cubierta"].Value);
            var navio = Convert.ToInt32(DgvReserva.SelectedRows[0].Cells["cod_navio"].Value);
            reservacionesServicios.EliminarReserva(id, num, fecha, cubierta, navio);
            DgvReserva.Rows.Clear();
            CargarReserva();
        }

        private void ConsultarReserva_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarFormulario();
        }
    }
}

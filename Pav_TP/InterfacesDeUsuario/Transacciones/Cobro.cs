using Pav_TP.Entidades;
using Pav_TP.Repositorios;
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
    public partial class Cobro : Form
    {
        private readonly CobroServicios cobroServicio;
        private readonly FrmPrincipal frmPrincipa;

        public Cobro(FrmPrincipal frmPrincipal)
        {
            cobroServicio = new CobroServicios();
            frmPrincipa = frmPrincipal;
            InitializeComponent();

        }

        private void Cobro_Load(object sender, EventArgs e)
        {
            cargarReservaciones();
            cargarModos();
        }

        private void cargarReservaciones()
        {
            var reservaciones = cobroServicio.GetReservaciones();
            var reservaDefault= new Reservaciones();
            reservaDefault.num_reservacion = 0;
            reservaciones.Add(reservaDefault);

            var conector = new BindingSource();
            conector.DataSource = reservaciones;

            CmbReservas.DataSource = conector;
            CmbReservas.DisplayMember = "num_reservacion";
            CmbReservas.ValueMember = "num_reservacion";
            CmbReservas.SelectedItem = reservaDefault;


        }

        private void cargarModos()
        {
            var modos2= cobroServicio.GetModos();
            var modoDefault = new Modo_pago();
            modoDefault.descripcion="Seleccionar";
            modos2.Add(modoDefault);

            var conector = new BindingSource();
            conector.DataSource = modos2;

            CmbModosPagos.DataSource = conector;
            CmbModosPagos.DisplayMember = "descripcion";
            CmbModosPagos.ValueMember = "modo_pago";
            CmbModosPagos.SelectedItem = modoDefault;

        }



        private void Cobro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cerrar_cuestionario();
        }

        private void Cerrar_cuestionario()
        {
            frmPrincipa.Show();
            Dispose();
        }

        private void CmbModosPagos_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}

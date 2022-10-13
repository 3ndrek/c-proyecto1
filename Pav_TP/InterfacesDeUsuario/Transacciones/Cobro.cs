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
        private readonly Entidades.Pasajero pasajeroFiltro;
        private readonly Entidades.Cobros cobro1;
        private readonly pasajeroXreserva pxR;

        public Cobro(FrmPrincipal frmPrincipal)
        {
            cobroServicio = new CobroServicios();
            frmPrincipa = frmPrincipal;
            pasajeroFiltro = new Entidades.Pasajero();
            cobro1 = new Entidades.Cobros();
            pxR = new pasajeroXreserva();
            InitializeComponent();

        }

        private void Cobro_Load(object sender, EventArgs e)
        {
            // cargarReservaciones();
            cargarModos();
            cargarTiposDoc();
            NombrePasajero.Hide();
            ApellidoMostrar.Hide();
        }


        private void cargarTiposDoc()
        {
            var tiposDoc = cobroServicio.GetTipos();
            var tipoDefault = new TipoDoc();
            tipoDefault.desc = "seleccionar ";
            tipoDefault.tipo = 0;
            tiposDoc.Add(tipoDefault);

            var conector = new BindingSource();
            conector.DataSource = tiposDoc;

            CmbTipoDoc.DataSource = conector;
            CmbTipoDoc.DisplayMember = "desc";
            CmbTipoDoc.ValueMember = "tipo";
            CmbTipoDoc.SelectedItem = tipoDefault;
        }



        
        private void cargarReservaciones(Entidades.Pasajero filtro)
        {
            var reservaciones = cobroServicio.GetReservaciones(filtro);
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
            cobro1.modo_pago = (int)CmbModosPagos.SelectedValue;
        }

        private void BtnPasajero_Click(object sender, EventArgs e)
        {
            pasajeroFiltro.num_doc = Convert.ToInt32(TxtNroDoc.Text);

            try 
            {
                var pasajeroAMostrar = cobroServicio.GetPasajeros(pasajeroFiltro);

                foreach (var item in pasajeroAMostrar)
                {
                    NombrePasajero.Text = item.nombre;
                    ApellidoMostrar.Text = item.apellido;
                    NombrePasajero.Show();
                    ApellidoMostrar.Show();

                    pasajeroFiltro.nombre= item.nombre;
                    pasajeroFiltro.apellido= item.apellido;
                }

                cargarReservaciones(pasajeroFiltro);


            }
            // por el camino del bien funciona, ahora hay que hacer la validación para que se actualice cuando no se encuentra nada 
            catch (NullReferenceException ex)
            {

                throw new Exception(ex.Message);
            }

        }

        private void CmbTipoDoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pasajeroFiltro.tipo_doc = (int)CmbTipoDoc.SelectedValue;
        }





        private void button1_Click(object sender, EventArgs e)
        {
            cargaPasajero(); 


        }



        private void cargaPasajero ()
        {
            NuevoCobro();
            cobro1.monto = Convert.ToInt32(TxtMonto.Text);
            
            pxR.cobros = cobro1;
            pxR.tipo_doc= (int)CmbTipoDoc.SelectedValue;
            pxR.num_doc= Convert.ToInt32(TxtNroDoc.Text);
            pxR.estado_reserva = "c";
            cobroServicio.registrarPxR(pxR);

            MessageBox.Show("se registró el cobro con exito", "Cobro", MessageBoxButtons.OK);
        }


        private void NuevoCobro()
        {
            cobro1.fecha_pago = FechaPagoSeleccionador.Value;

        }

        private void CmbReservas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cobro1.nro_reserva = (int)CmbReservas.SelectedValue;
        }
    }
}

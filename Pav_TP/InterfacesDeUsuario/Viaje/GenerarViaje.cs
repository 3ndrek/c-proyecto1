using Pav_TP.Entidades;
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

namespace PAV1
{
    public partial class GenerarViaje : Form
    {
        private Viaje viaje;
        private readonly ViajesServicios viajesServicios;
        private readonly BarcosServicios barcosServicios;

        private readonly FrmPrincipal frmPrincipal;
        public GenerarViaje(FrmPrincipal frmPrincipal1)
        {
            frmPrincipal = frmPrincipal1;
            viajesServicios = new ViajesServicios();
            barcosServicios = new BarcosServicios();
            InitializeComponent();
        }

        private void GenerarViaje_Load(object sender, EventArgs e)
        {
            CargarItinerario();
            CargarBarco();
        }
        public void CargarBarco()
        {
            var barco = viajesServicios.ObtenerBarco();
            var barcoSeleccionar = new Barco();
            barcoSeleccionar.Nombre = "Seleccionar";
            barco.Add(barcoSeleccionar);

            var conector = new BindingSource();
            conector.DataSource = barco;

            cmbCod.DataSource = conector;
            cmbCod.DisplayMember = "nombre";
            cmbCod.ValueMember = "Codigo";
            cmbCod.SelectedItem = barcoSeleccionar;
        }
        public void CargarItinerario()
        {
            var itinerario = viajesServicios.GetItinerarios();
            var tipoSeleccionar = new Itinerario();
            tipoSeleccionar.Descripcion = "Seleccionar";
            itinerario.Add(tipoSeleccionar);

            var conector = new BindingSource();
            conector.DataSource = itinerario;

            cmbItininerario.DataSource = conector;
            cmbItininerario.DisplayMember = "Descripcion";
            cmbItininerario.ValueMember = "Cod_itinerario";
            cmbItininerario.SelectedItem = tipoSeleccionar;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!esOperacionConfirmada())
                    return;
                if (!esViajeValido())
                    return;
                VerificarFecha();
                RegistrarViajee();


            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool esOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("Desea confirmar la operación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes) { return true; }
            return false;
        }

        public bool esViajeValido()
        {

            var cod = (Barco)cmbCod.SelectedItem;
            var fecha = Convert.ToDateTime(dateTimePicker1.Text.Trim());
            var duracion = Convert.ToInt32(TxtDuracion.Text.Trim());
            var itinerario = (Itinerario)cmbItininerario.SelectedItem;

            var viajeIngresado = new Viaje();
            viajeIngresado.Cod_navio = cod.Codigo;
            viajeIngresado.FechaSalida = fecha;
            viajeIngresado.Itinerario = itinerario.Cod_Itinerario;
            viajeIngresado.Duracion = duracion;

            viajesServicios.ValidarViaje(viajeIngresado);
            viaje = viajeIngresado;
            return true;
        }

        public void RegistrarViajee()
        {
            if (viajesServicios.RegistrarViaje(viaje))
            {
                MessageBox.Show("El viaje se registro exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Ocurrio un problema para registrar , intentelo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }
        private void CerrarFormulario()
        {
            frmPrincipal.Show();
            this.Dispose();
        }

        private void GenerarViaje_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarFormulario();
        }

        private void VerificarFecha()
        {
            var cod = (Barco)cmbCod.SelectedItem;

            BarcoFecha nuevoBarco = new BarcoFecha();
            nuevoBarco.cod_navio = cod.Codigo;
            nuevoBarco.duracion = int.Parse(TxtDuracion.Text);
            nuevoBarco.fechaFin = dateTimePicker1.Value.AddDays(nuevoBarco.duracion);
            nuevoBarco.fechaIncio = dateTimePicker1.Value;

            var fechas = viajesServicios.GetBarcoFechas(nuevoBarco);
           /*
            var fechaI = Convert.ToDateTime(dateTimePicker1.Text.Trim());
            var duracion = Convert.ToInt32(TxtDuracion.Text.Trim());
            var fechaF = fechaI.AddDays(duracion);
           */
            //var viajeSelec = new BarcoFecha();
            //viajeSelec.cod_navio = cod.cod_navio;
            //viajeSelec.fechaIncio = fechaI;
            //viajeSelec.fechaFin = fechaF;
            //viajeSelec.duracion = duracion;

            

            foreach (BarcoFecha fecha in fechas)
            {
                if (!(nuevoBarco.fechaIncio < fecha.fechaIncio || nuevoBarco.fechaIncio > fecha.fechaFin))
                {
                    throw new ApplicationException("La fecha seleccionada no esta disponible");
                    //MessageBox.Show("La fecha seleccionada no esta disponible, intentelo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!(nuevoBarco.fechaFin < fecha.fechaIncio || nuevoBarco.fechaFin > fecha.fechaFin))
                {
                    throw new ApplicationException("La fecha seleccionada no esta disponible");
                    return;
                }
            }
        }

        //private void cmbCod_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    // fecha_incio, duracion
        //    var fechaInicio = DateTime.Now;
        //    var duracion = 10;
        //    var datosViaje = viajesServicios.get_fecha_duracion(idNAvio);
        //    // datosViajes: FEchaInicio, FechaFin
        //    var fechaFin = fechaInicio.AddDays(duracion);
        //    var fechaInicioSeleccoinada = dateTimePicker1.Value;
        //    var fechaFinSeleccionada = 
        //}
    }
    
}

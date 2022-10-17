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
        private readonly PaisesServicios paisesServicios;
        private readonly ViajesServicios viajesServicios;
        private readonly BarcosServicios barcosServicios;

        private readonly FrmPrincipal frmPrincipal;
        public GenerarViaje(FrmPrincipal frmPrincipal1)
        {
            frmPrincipal = frmPrincipal1;
            paisesServicios = new PaisesServicios();
            viajesServicios = new ViajesServicios();
            barcosServicios = new BarcosServicios();
            InitializeComponent();
        }

        private void GenerarViaje_Load(object sender, EventArgs e)
        {
            CargarOrigen();
            CargarDestino();
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


        public void CargarOrigen()
        {
            var pais = paisesServicios.GetPaises();
            var paisSeleccionar = new Paises();
            paisSeleccionar.nombre = "Seleccionar";
            pais.Add(paisSeleccionar);

            var conector = new BindingSource();
            conector.DataSource = pais;

            cmbOrigen.DataSource = conector;
            cmbOrigen.DisplayMember = "nombre";
            cmbOrigen.ValueMember = "cod_pais";
            cmbOrigen.SelectedItem = paisSeleccionar;
        }

        public void CargarDestino()
        {
            var pais = paisesServicios.GetPaises();
            var paisSeleccionar = new Paises();
            paisSeleccionar.nombre = "Seleccionar";
            pais.Add(paisSeleccionar);

            var conector = new BindingSource();
            conector.DataSource = pais;

            cmbDestino.DataSource = conector;
            cmbDestino.DisplayMember = "nombre";
            cmbDestino.ValueMember = "cod_pais";
            cmbDestino.SelectedItem = paisSeleccionar;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!esOperacionConfirmada())
                    return;
                if (!esViajeValido())
                    return;
                RegistrarViajee();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var origen = (Paises)cmbOrigen.SelectedItem;
            var destino = (Paises)cmbDestino.SelectedItem;

            var viajeIngresado = new Viaje();
            viajeIngresado.Cod_navio = cod.Codigo;
            viajeIngresado.FechaSalida = fecha;
            viajeIngresado.Itinerario = itinerario.Cod_Itinerario;
            viajeIngresado.Duracion = duracion;
            viajeIngresado.Origen = origen.cod_pais;
            viajeIngresado.Destino = destino.cod_pais;

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
    }
    
}

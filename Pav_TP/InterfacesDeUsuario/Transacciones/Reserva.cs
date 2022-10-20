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

namespace Pav_TP.InterfacesDeUsuario.Transacciones
{
    public partial class Reserva : Form
    {
        private ReservacionesServicios reseracionesServicios;
        private PuertoServicios puertoServicios;
        private ViajesServicios viajesServicios;
        private static FrmPrincipal frmPrincipal;
        private readonly Reservaciones reserva;
        private readonly CobroServicios cobroServicio;
        private Entidades.Pasajero pasajero;
        private int bloqueoBusqueda;

        public Reserva(FrmPrincipal Principal)
        {
            reserva = new Reservaciones();
            frmPrincipal = Principal;
            reseracionesServicios = new ReservacionesServicios();
            puertoServicios = new PuertoServicios();
            viajesServicios = new ViajesServicios();
            cobroServicio = new CobroServicios();
            pasajero = new Entidades.Pasajero();
            bloqueoBusqueda = new int();
            InitializeComponent();
        }

        private void Reserva_Load(object sender, EventArgs e)
        {
            CargarItinerarios();
            cargarTiposDoc();
            nombrePasajero.Hide();
            apellidoPasajero.Hide();
            bloqueoBusqueda = 0;
        }

        private void CargarItinerarios()
        {
            var itine = reseracionesServicios.getItinerarios();
            var itineDefecto = new Entidades.Itinerario();
            itineDefecto.Descripcion = "Seleccionar";
            itine.Add(itineDefecto);

            var conector = new BindingSource();
            conector.DataSource = itine;

            CmbItinerario.DataSource = conector;
            CmbItinerario.ValueMember = "cod_itinerario";
            CmbItinerario.DisplayMember = "Descripcion";
            CmbItinerario.SelectedValue = itineDefecto;
        }

        private void Reserva_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            frmPrincipal.Show();
        }

        private void CmbItinerario_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var seleccionadaIitinerario = (Entidades.Itinerario)CmbItinerario.SelectedItem;
            var puertos = puertoServicios.GetPuertos(seleccionadaIitinerario);
            DgvPuertos.Rows.Clear();
            foreach (var puerto in puertos )
            {
                var fila = new string[]
                {
                    puerto.nombre.ToString(),
                };
                DgvPuertos.Rows.Add(fila);
            }

            var viajes = viajesServicios.GetViajes(seleccionadaIitinerario);
            DgvViajes.Rows.Clear();
            foreach (var viaje in viajes)
            {
                var fila = new string[]
                {
                    viaje.Cod_navio.ToString(),
                    viaje.FechaSalida.ToString(),
                    viaje.Duracion.ToString(),

                };
                DgvViajes.Rows.Add(fila);

            }
            bloqueoBusqueda = 1;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (bloqueoBusqueda != 0)
            {



                var cod = Convert.ToInt32(DgvViajes.SelectedRows[0].Cells["cod_navio"].Value);
                var cant_camas = Convert.ToInt32(TxtCant.Text.Trim());

                var camarotes = reseracionesServicios.ObtenerCamarotes(cod, cant_camas);

                DgvCamarotes.Rows.Clear();
                foreach (var camarot in camarotes)
                {
                    var fila = new string[]
                    {
                    camarot.cod_navio.ToString(),
                    camarot.num_camarote.ToString(),
                    camarot.cubierta_desc.ToString(),
                    camarot.tipo_desc.ToString(),
                    camarot.cant_camas.ToString(),
                    camarot.num_cubierta.ToString(),
                    camarot.monto.ToString()
                    };
                    DgvCamarotes.Rows.Add(fila);
                }
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarReserva();

               

                /*TxtNroDoc.Clear();
                NombrePasajero.Hide();
                ApellidoMostrar.Hide();
                TxtMonto.Clear();*/
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("No se pudo realizar la reserva ", "Reserva", MessageBoxButtons.OK);
            }
        }



        private void CargarReserva()
        {
            reserva.cod_navio = Convert.ToInt32(DgvCamarotes.SelectedRows[0].Cells["codigo_navio"].Value);
            reserva.num_cubierta = Convert.ToInt32(DgvCamarotes.SelectedRows[0].Cells["num_cubierta"].Value);
            reserva.num_camarote = Convert.ToInt32(DgvCamarotes.SelectedRows[0].Cells["num_camarote"].Value);
            reserva.cama_ocupada = Convert.ToInt32(TxtCant.Text.Trim());
            reserva.fecha_viaje = Convert.ToDateTime(DgvViajes.SelectedRows[0].Cells["fecha_salida"].Value);
            reserva.estado_reserva = "Activo";
            reserva.tipo_doc = (int)pasajero.tipo_doc;
            reserva.num_doc = (int)pasajero.num_doc;
            reserva.monto = Convert.ToInt32(DgvCamarotes.SelectedRows[0].Cells["monto"].Value);

           
            DialogResult result = MessageBox.Show($"la reservación corresponde a {pasajero.nombre}, {pasajero.apellido}, y se va a reservar el camarote: {reserva.num_camarote}, con {reserva.cama_ocupada} camas ocupadas, El monto total es: {reserva.monto}", "reservaciones",MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                try
                {
                    reseracionesServicios.CargarReserva(reserva);
                    MessageBox.Show("se registró la reserva con exito", "Reserva", MessageBoxButtons.OK);
                    nombrePasajero.Hide();
                    apellidoPasajero.Hide();
                    bloqueoBusqueda = 0;
                }
                catch (Exception)
                {
                    // cargar los errores 
                    throw;
                }

            }



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

        private void CmbTipoDoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pasajero.tipo_doc = (int)CmbTipoDoc.SelectedValue;
        }

        private void TxtNroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar)) //Comparas si la tecla presionada corresponde a un signo de puntuacion
            {
                e.Handled = true; //Si coincide se controla el evento, es decir, no se escribe el caracter
            }
            if (Char.IsSymbol(e.KeyChar)) //Comparas si la tecla presionada corresponde a un simbolo
            {
                e.Handled = true;
            }
            if (Char.IsLetter(e.KeyChar)) //Comparas si la tecla presionada corresponde a una letra
            {
                e.Handled = true;
            }

            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }




        private void BtnBuscarPasajero_Click(object sender, EventArgs e)
        {
            
            pasajero.num_doc = Convert.ToInt32(TxtNroDoc.Text);

            var pasajeroAMostrar = cobroServicio.GetPasajeros(pasajero);

            foreach (var item in pasajeroAMostrar)
            {
                nombrePasajero.Text = item.nombre;
                apellidoPasajero.Text = item.apellido;
                nombrePasajero.Show();
                apellidoPasajero.Show();

                pasajero.nombre = item.nombre;
                pasajero.apellido = item.apellido;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmPrincipal.Show();
        }
    }
}

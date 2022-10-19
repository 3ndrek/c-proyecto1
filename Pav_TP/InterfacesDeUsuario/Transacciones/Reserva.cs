﻿using Pav_TP.Entidades;
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

        public Reserva(FrmPrincipal Principal)
        {
            reserva = new Reservaciones();
            frmPrincipal = Principal;
            reseracionesServicios = new ReservacionesServicios();
            puertoServicios = new PuertoServicios();
            viajesServicios = new ViajesServicios();
            InitializeComponent();
        }

        private void Reserva_Load(object sender, EventArgs e)
        {
            CargarItinerarios();
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
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
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
                    camarot.num_cubierta.ToString()
                };
                DgvCamarotes.Rows.Add(fila);
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarReserva();

                DialogResult result = MessageBox.Show("se registró la reserva con exito", "Reserva", MessageBoxButtons.OK);

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
            /*reserva.tipo_doc = */
            reserva.fecha_viaje = Convert.ToDateTime(DgvViajes.SelectedRows[0].Cells["fecha_salida"].Value);
            reserva.estado_reserva = "Activo";
            reseracionesServicios.CargarReserva(reserva);
        }
    }
}

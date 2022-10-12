﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pav_TP.InterfacesDeUsuario.Puerto;
using Pav_TP.Servicios;
using PAV1;
using TrabajoPracticoPav;
using Pav_TP.InterfacesDeUsuario;
using Pav_TP.InterfacesDeUsuario.Barco;
using Pav_TP.InterfacesDeUsuario.Usuario;
using Pav_TP.InterfacesDeUsuario.Camarote;
using Pav_TP.InterfacesDeUsuario.Transacciones;

namespace seastar
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }


        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)

        {
            while (UsuariosServicio.UsuarioLogueado == null)
            {   
               var frmLogin = new FrmLogin(this);
               frmLogin.ShowDialog();
               
                if (UsuariosServicio.UsuarioLogueado == null)
                {
                    DialogResult result = MessageBox.Show("error ingrese un usuario","Inicio de sesión erroneo", MessageBoxButtons.RetryCancel);

                    if (result == DialogResult.Retry)
                    {
                        var frmLogin1 = new FrmLogin(this);
                        frmLogin1.ShowDialog();

                    }

                    else if (result == DialogResult.Cancel)
                    {
                        this.Dispose();
                    }



                }

            }

           

        }

        private void registrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form registrarTripulante = new RegistrarTripulante(this);
            registrarTripulante.Show();
            this.Hide();
        }
        private void modificarTriToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
        }
        private void consultarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form consultarTripulante = new ConsultarTripulante(this);
            consultarTripulante.Show();
            this.Hide();
        }

        private void registrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form registrarPasajero = new RegistrarPasajero(this);
            registrarPasajero.Show();
            this.Hide();
        }
        private void consultarPasajero_Click(object sender, EventArgs e)
        {
            ConsultarPasajero consultarPasajero = new ConsultarPasajero(this);
            consultarPasajero.Show();
            this.Hide();
        }


        private void registrarBarco_Click(object sender, EventArgs e)
        { 
            
           
        }
      

        private void consultarCubierta_Click(object sender, EventArgs e)
        {
            Form consultarCubierta = new ConsultarCubierta(this);
            consultarCubierta.Show();
            this.Hide();
        }
        private void registrarCubierta_Click(object sender, EventArgs e)
        {
            RegistrarCubierta registrarCubierta = new RegistrarCubierta(this);
            registrarCubierta.Show();
            this.Hide();
        }
        private void modificarCubierta_Click(object sender, EventArgs e)
        {
            ModificarCubierta modificarCubierta = new ModificarCubierta(this);
            modificarCubierta.Show();
            this.Hide();
        }
        private void eliminarCubierta_Click(object sender, EventArgs e)
        {
            EliminarCubierta eliminarCubierta = new EliminarCubierta(this);
            eliminarCubierta.Show();
            this.Hide();
        }

        private void puertoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void registrarBarco_Click_1(object sender, EventArgs e)
        {
            RegistrarBarco registrarBarco = new RegistrarBarco(this);  
            registrarBarco.Show();
            this.Hide();
        }


        private void consultarBarco_Click(object sender, EventArgs e)
        {
            ConsultarBarco consultarBarco = new ConsultarBarco(this);
            consultarBarco.Show();
            this.Hide();
        }

        private void generarViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarViaje generarViaje = new GenerarViaje(this);
            generarViaje.Show();
            this.Hide();
        }
        private void consultarViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarViaje consultarViaje = new ConsultarViaje(this);
            consultarViaje.Show();
            this.Hide();
        }


        private void eliminarViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 eliminarViaje = new Form9();
            eliminarViaje.Show();
            this.Hide();
        }

        private void cubiertaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarUsuario modificarUsuario = new ModificarUsuario(this);
            modificarUsuario.Show();
            this.Hide();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarUsuario registrarUsuario = new RegistrarUsuario(this);
            registrarUsuario.Show();
            this.Hide();
        }

        private void cambiarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarUsuario consultarUsuario = new ConsultarUsuario(this);
            consultarUsuario.Show();
            this.Hide( );
        }

        private void itinerarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarPuerto_Click(object sender, EventArgs e)
        {
            RegistrarPuerto registrarPuerto = new RegistrarPuerto();
            registrarPuerto.Show();
            this.Hide();
        }

        private void consultarPuerto_Click(object sender, EventArgs e)
        {
            ConsultarPuerto consultarPuerto = new ConsultarPuerto();
            consultarPuerto.Show();
            this.Hide();
        }

        private void registrarCamaroteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarCamarote registrarCamarote = new RegistrarCamarote(this);
            registrarCamarote.Show();
            this.Hide();
        }

        private void consultarCamaroteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCamarote consultarCamarote = new ConsultarCamarote(this);
            consultarCamarote.Show();
            this.Hide();
        }

        private void modificarCamaroteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarCamarote modificarCamarote = new ModificarCamarote(this);
            modificarCamarote.Show();
            this.Hide();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva();
            reserva.Show();
            this.Hide();
        }

        private void cobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cobro cobro = new Cobro(this);
            cobro.Show();
            this.Hide();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Itinerario itinerario = new Itinerario(this);
            itinerario.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gestionarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

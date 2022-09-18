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

namespace seastar
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }


        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)

        {
            /*
             * esperemos que nacho arregle el login
             * esta es la carga para que aparezca primero el Login 
            if(UsuariosServicio.UsuarioLogueado == null)
            {
                
                var frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
                
            }

            */

        }

        private void registrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form registrarTripulante = new RegistrarTripulante();
            registrarTripulante.Show();
            this.Hide();
        }
        private void modificarTriToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
        }
        private void consultarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form consultarTripulante = new ConsultarTripulante();
            consultarTripulante.Show();
            this.Hide();
        }

        private void registrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form registrarPasajero = new RegistrarPasajero();
            registrarPasajero.Show();
            this.Hide();
        }
        private void consultarPasajero_Click(object sender, EventArgs e)
        {
            ConsultarPasajero consultarPasajero = new ConsultarPasajero();
            consultarPasajero.Show();
            this.Hide();
        }


        private void registrarBarco_Click(object sender, EventArgs e)
        { 
            
           
        }
      

        private void consultarCubierta_Click(object sender, EventArgs e)
        {
            Form consultarCubierta = new ConsultarCubierta();
            consultarCubierta.Show();
            this.Hide();
        }
        private void registrarCubierta_Click(object sender, EventArgs e)
        {
            RegistrarCubierta registrarCubierta = new RegistrarCubierta();
            registrarCubierta.Show();
            this.Hide();
        }
        private void modificarCubierta_Click(object sender, EventArgs e)
        {
            ModificarCubierta modificarCubierta = new ModificarCubierta();
            modificarCubierta.Show();
            this.Hide();
        }
        private void eliminarCubierta_Click(object sender, EventArgs e)
        {
            EliminarCubierta eliminarCubierta = new EliminarCubierta();
            eliminarCubierta.Show();
            this.Hide();
        }

        private void puertoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void registrarBarco_Click_1(object sender, EventArgs e)
        {
            RegistrarBarco registrarBarco = new RegistrarBarco();  
            registrarBarco.Show();
            this.Hide();
        }
        private void modificarBarco_Click(object sender, EventArgs e)
        {
            ModificarBarco modificarBarco = new ModificarBarco();   
            modificarBarco.Show();
            this.Hide();
        }
        private void eliminarBarco_Click(object sender, EventArgs e)
        {
            EliminarBarco eliminarBarco = new EliminarBarco();
            eliminarBarco.Show();
            this.Hide();
        }
        private void consultarBarco_Click(object sender, EventArgs e)
        {
            ConsultarBarco consultarBarco = new ConsultarBarco();
            consultarBarco.Show();
            this.Hide();
        }

        private void generarViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarViaje generarViaje = new GenerarViaje();
            generarViaje.Show();
            this.Hide();
        }
        private void consultarViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarViaje consultarViaje = new ConsultarViaje();
            consultarViaje.Show();
            this.Hide();
        }
        private void modificarViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarViaje modificarViaje = new ModificarViaje();
            modificarViaje.Show();
            this.Hide();
        }
        private void eliminarViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 eliminarViaje = new Form9();
            eliminarViaje.Show();
            this.Hide();
        }

        
    }
}

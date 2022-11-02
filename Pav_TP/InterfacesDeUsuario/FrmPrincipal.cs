using Pav_TP.ReportesYSalidas;
using System;
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
using Pav_TP.ReportesYSalidas.Reporte;

namespace seastar
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarForm);
            validadSesion();

        }

        private void cerrarForm(object sender, EventArgs e)
        {
            Dispose();
        }
        private void validadSesion()
        {
           
            while (UsuariosServicio.VarCierre == false)
            {
                var usuarioLog = 0;

                if (UsuariosServicio.UsuarioLogueado == null & usuarioLog == 0)
                {
                    this.Hide();
                    var frmLogin = new FrmLogin(this);
                    frmLogin.ShowDialog();
                    UsuariosServicio.VarCierre = true;
                    if (UsuariosServicio.UsuarioLogueado != null)
                    {
                        LblUsuario.Text = UsuariosServicio.UsuarioLogueado.NombreUsuario;
                    }
                    this.Show();
                }
            }
            if (UsuariosServicio.VarCierre & UsuariosServicio.UsuarioLogueado == null)
            {
                this.Dispose();
            }

        }

        private void registrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form registrarTripulante = new RegistrarTripulante(this);
            registrarTripulante.Show();
            this.Hide();
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
            Reserva reserva = new Reserva(this);
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

        private void pruebaButton1_Click(object sender, EventArgs e)
        {
            UsuariosServicio.UsuarioLogueado = null;
            UsuariosServicio.VarCierre = false;
            validadSesion();
        }

        private void consultarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarReserva consultarReserva = new ConsultarReserva(this);
            consultarReserva.Show();
            this.Hide();
        }

        private void gestionarReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new ReporteReserva();
            frm.ShowDialog();
        }
    }
}

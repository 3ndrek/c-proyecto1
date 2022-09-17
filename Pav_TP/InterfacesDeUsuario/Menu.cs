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

namespace seastar
{
    public partial class Menu : Form
    {
        public Menu()
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
            registrarTripulante.ShowDialog();
        }

        private void modificarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
        }

        private void consultarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form consultarTripulante = new ConsultarTripulante();
            consultarTripulante.ShowDialog();
        }

        private void registrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form registrarPasajero = new RegistrarPasajero();
            registrarPasajero.ShowDialog();
        }


        private void registrarBarco_Click(object sender, EventArgs e)
        {
           
        }
      

        private void consultarCubierta_Click(object sender, EventArgs e)
        {
            Form consultarCubierta = new ConsultarCubierta();
            consultarCubierta.ShowDialog();
        }

        private void registrarCubierta_Click(object sender, EventArgs e)
        {

        }

        private void puertoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generarViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}

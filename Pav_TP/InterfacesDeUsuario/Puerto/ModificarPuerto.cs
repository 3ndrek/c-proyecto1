using Pav_TP.Entidades;
using Pav_TP.InterfacesDeUsuario.Barco;
using Pav_TP.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pav_TP.InterfacesDeUsuario.Puerto
{
    public partial class ModificarPuerto : Form
    {
        private Entidades.Puerto puerto;
        private PuertosServicios puertosServicios;
        public ModificarPuerto(int id)
        {
            puertosServicios = new PuertosServicios();
            puerto = puertosServicios.GetPuertos(id);
            InitializeComponent();
        }

        private void ModificarPuerto_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public void CargarDatos()
        {
            TxtNombre.Text = puerto.Nombre;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                if (!EsPuertoValido())
                    return;
                ActualizarPuerto();
                CerrarFormulario();


            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EsPuertoValido()
        {
            var puertoIngresado = new Entidades.Puerto();
            puertoIngresado.Codigo = puerto.Codigo;
            puertoIngresado.Nombre = TxtNombre.Text;

            puertosServicios.ValidarPuerto(puertoIngresado);
            puerto = puertoIngresado;
            return true;
        }

        public void ActualizarPuerto()
        {
            puertosServicios.ActualizarPuerto(puerto);
            MessageBox.Show("Se actualizo correctamente el barco", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CerrarFormulario()
        {
            this.Dispose();
        }

        private void pruebaButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            //frmPrincipal.Show();
        }
    }
}
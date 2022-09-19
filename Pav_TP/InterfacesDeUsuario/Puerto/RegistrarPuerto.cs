using Pav_TP.Entidades;
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
    public partial class RegistrarPuerto : Form
    {
        private Entidades.Puerto puerto;
        private PuertosServicios puertosServicios;

        public RegistrarPuerto()
        {
            puertosServicios = new PuertosServicios();
            InitializeComponent();
        }

        private void btbRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!esOperacionConfirmada())
                    return;
                if (!esPuertoValido())
                    return;
                RegistrarPuertoo();
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

        public bool esPuertoValido()
        {
            var puertoIngresado = new Entidades.Puerto();
            puertoIngresado.Nombre = TxtNombre.Text;

            puertosServicios.ValidarPuerto(puertoIngresado);
            puerto = puertoIngresado;
            return true;
        }

        public void RegistrarPuertoo()
        {
            if (puertosServicios.RegistrarPuerto(puerto))
            {
                MessageBox.Show("El barco se registro exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Ocurrio un problema para registrar el barco, intentelo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

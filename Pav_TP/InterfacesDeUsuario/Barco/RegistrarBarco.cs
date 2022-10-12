using Pav_TP.Entidades;
using Pav_TP.Servicios;
using seastar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pav_TP.InterfacesDeUsuario.Barco
{
    public partial class RegistrarBarco : Form 
    {
        private Entidades.Barco barco;
        private ClasificacionesServicios clasificacionesServicios;
        private BarcosServicios barcosServicios;

        private readonly FrmPrincipal frmPrincipal;
        public RegistrarBarco( FrmPrincipal frmPrincipal1)
        {
            frmPrincipal = frmPrincipal1;
            barcosServicios = new BarcosServicios();
            clasificacionesServicios = new ClasificacionesServicios();
            InitializeComponent();
        }

        private void RegistrarBarco_Load(object sender, EventArgs e)
        {
            CargarClasificaciones();
        }

        public void CargarClasificaciones()
        {
            var clasificaciones = clasificacionesServicios.GetClasificaciones();
            var clasificacionSeleccionar = new Clasificacion();
            clasificacionSeleccionar.Desc = "Seleccionar";
            clasificaciones.Add(clasificacionSeleccionar);

            var conector = new BindingSource();
            conector.DataSource = clasificaciones;

            CbClasificacion.DataSource = conector;
            CbClasificacion.DisplayMember = "Desc";
            CbClasificacion.ValueMember = "Cod";
            CbClasificacion.SelectedItem = clasificacionSeleccionar;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!esOperacionConfirmada())
                    return;
                if (!esBarcoValido())
                    return;
                RegistrarBarcoo();
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

        public bool esBarcoValido()
        {
            var nombre = TxtNombre.Text;
            var altura = Convert.ToInt32(TxtAltura.Text.Trim());
            var eslora = Convert.ToInt32(TxtEslora.Text.Trim());
            var manga = Convert.ToInt32(TxtManga.Text.Trim());
            var desplazamiento = Convert.ToInt32(TxtDesplazamiento.Text.Trim());
            var autonomia = Convert.ToInt32(TxtAutonomia.Text.Trim());
            var cantCamarotes = Convert.ToInt32(TxtCamarotes.Text.Trim());
            var cantMaxPasajeros = Convert.ToInt32(TxtPasajeros.Text.Trim());
            var cantMotores = Convert.ToInt32(TxtMotores.Text.Trim());
            var cantTripulantes = Convert.ToInt32(TxtTripulantes.Text.Trim());
            var clasificacion = (Clasificacion)CbClasificacion.SelectedItem;

            var barcoIngresado = new Entidades.Barco();
            barcoIngresado.Nombre = nombre;
            barcoIngresado.Altura = altura;
            barcoIngresado.Eslora = eslora;
            barcoIngresado.Manga = manga;
            barcoIngresado.Desplazamiento = desplazamiento;
            barcoIngresado.Autonomia = autonomia;
            barcoIngresado.CantCamarote = cantCamarotes;
            barcoIngresado.CantMaxPasajeros = cantMaxPasajeros;
            barcoIngresado.CantMotores = cantMotores;
            barcoIngresado.CantTripulante = cantTripulantes;
            barcoIngresado.Clasificacion = clasificacion.Cod;

            barcosServicios.ValidarBarco(barcoIngresado);
            barco = barcoIngresado;
            return true;
        }

        public void RegistrarBarcoo()
        {
            if (barcosServicios.RegistrarBarco(barco))
            {
                MessageBox.Show("El barco se registro exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Ocurrio un problema para registrar el barco, intentelo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void CerrarFormulario()
        {
            frmPrincipal.Show();
            this.Dispose();

        }
        private void RegistrarBarco_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarFormulario();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}

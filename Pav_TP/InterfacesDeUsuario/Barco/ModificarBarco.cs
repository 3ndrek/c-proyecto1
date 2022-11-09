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
    public partial class ModificarBarco : Form
    {
        private Entidades.Barco barco;
        private BarcosServicios barcosServicios;
        private ClasificacionesServicios clasificacionesServicios;
        private readonly FrmPrincipal frmPrincipal;

        public ModificarBarco(int id)
        {
            barcosServicios = new BarcosServicios();
            clasificacionesServicios = new ClasificacionesServicios();
            barco = barcosServicios.GetBarcos(id);
            InitializeComponent();
        }

        private void ModificarBarco_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarClasificaciones();
        }

        private void CargarDatos()
        {
            TxtNombre.Text = barco.Nombre;
            TxtAltura.Text = barco.Altura.ToString();
            TxtEslora.Text = barco.Eslora.ToString();
            TxtManga.Text = barco.Manga.ToString();
            TxtDesplazamiento.Text = barco.Desplazamiento.ToString();
            TxtAutonomia.Text = barco.Autonomia.ToString();
            TxtCamarotes.Text = barco.CantCamarote.ToString();
            TxtPasajeros.Text = barco.CantMaxPasajeros.ToString();
            TxtMotores.Text = barco.CantMotores.ToString();
            TxtTripulantes.Text = barco.CantTripulante.ToString();
            CbClasificacion.Text = barco.Clasificacion.ToString();
        }

        public void CargarClasificaciones()
        {
            var clasificaciones = clasificacionesServicios.GetClasificaciones();
            var conector = new BindingSource();
            conector.DataSource = clasificaciones;

            CbClasificacion.DataSource = conector;
            CbClasificacion.DisplayMember = "desc";
            CbClasificacion.ValueMember = "cod";

            var clasificacionSeleccionada = clasificaciones.First(p => p.Cod == barco.Clasificacion);
            CbClasificacion.SelectedItem = clasificacionSeleccionada;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                if (!EsBarcoValido())
                    return;
                ActualizarBarco();
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

        public bool EsBarcoValido()
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
            barcoIngresado.Codigo = barco.Codigo;
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

        public void ActualizarBarco()
        {
            barcosServicios.ActualizarBarco(barco);
            MessageBox.Show("Se actualizo correctamente el barco", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void pruebaButton2_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }
        private void CerrarFormulario()
        {
            
            this.Dispose();

        }
    }
}

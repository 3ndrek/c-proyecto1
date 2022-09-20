using Pav_TP.Entidades;
using Pav_TP.Servicios;
using seastar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoPav
{
    public partial class RegistrarPasajero : Form
    {

        private Pasajero pasajero;
        private TipoDocServicio tipoServicio;
        private CiudadServicios ciudadServicios;
        private PaisesServicios paisesServicios;
        private GeneroServicios generoServicios;
        private PasajerosServicios pasajerosServicios;

        private readonly FrmPrincipal frmPrincipal;

        public RegistrarPasajero(FrmPrincipal frmPrincipal1)
        {
            frmPrincipal = frmPrincipal1;
            pasajerosServicios = new PasajerosServicios();
            tipoServicio = new TipoDocServicio();
            ciudadServicios = new CiudadServicios();
            paisesServicios = new PaisesServicios();
            generoServicios = new GeneroServicios();
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CargarTipo();
            CargarCiudad();
            CargarPais();
            CargarGenero();
        }

        public void CargarTipo()
        {
            var tipos = tipoServicio.GetTipos();
            var tipoSeleccionar = new TipoDoc();
            tipoSeleccionar.desc = "Seleccionar";
            tipos.Add(tipoSeleccionar);

            var conector = new BindingSource();
            conector.DataSource = tipos;

            comboBoxDni.DataSource = conector;
            comboBoxDni.DisplayMember = "desc";
            comboBoxDni.ValueMember = "tipo";
            comboBoxDni.SelectedItem = tipoSeleccionar;
        }

        public void CargarCiudad()
        {
            var ciudad = ciudadServicios.GetCiudades();
            var ciudadSeleccionar = new Ciudad();
            ciudadSeleccionar.nombre = "Seleccionar";
            ciudad.Add(ciudadSeleccionar);

            var conector = new BindingSource();
            conector.DataSource = ciudad;

            comboBoxCiudad.DataSource = conector;
            comboBoxCiudad.DisplayMember = "nombre";
            comboBoxCiudad.ValueMember = "cod_ciudad";
            comboBoxCiudad.SelectedItem = ciudadSeleccionar;
        }

        public void CargarPais()
        {
            var pais = paisesServicios.GetPaises();
            var paisSeleccionar = new Paises();
            paisSeleccionar.nombre = "Seleccionar";
            pais.Add(paisSeleccionar);

            var conector = new BindingSource();
            conector.DataSource = pais;

            comboBoxPais.DataSource = conector;
            comboBoxPais.DisplayMember = "nombre";
            comboBoxPais.ValueMember = "cod_pais";
            comboBoxPais.SelectedItem = paisSeleccionar;
        }

        public void CargarGenero()
        {
            var genero = generoServicios.GetGeneros();
            var generoSeleccionar = new Genero();
            generoSeleccionar.desc = "Seleccionar";
            genero.Add(generoSeleccionar);

            var conector = new BindingSource();
            conector.DataSource = genero;

            comboBoxGenero.DataSource = conector;
            comboBoxGenero.DisplayMember = "desc";
            comboBoxGenero.ValueMember = "tipo";
            comboBoxGenero.SelectedItem = generoSeleccionar;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!esOperacionConfirmada())
                    return;
                if (!esPasajeroValido())
                    return;
                RegistrarPasajeroo();
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

        public bool esPasajeroValido()
        {
            var tipo = (TipoDoc)comboBoxDni.SelectedItem;
            var num = Convert.ToInt32(TxtDni.Text.Trim());
            var nombre = TxtNom.Text;
            var apellido = TxtApe.Text.Trim();
            var ciudad_procedente = (Ciudad)comboBoxCiudad.SelectedItem;
            var pais_procedente = (Paises)comboBoxPais.SelectedItem;
            var email = TxtEmail.Text.Trim();
            var fechaNac = Convert.ToDateTime(dateTimePicker2.Text.Trim());
            var genero = (Genero)comboBoxGenero.SelectedItem;
           

            var pasajeroIngresado = new Pasajero();
            pasajeroIngresado.tipo_doc = tipo.tipo;
            pasajeroIngresado.num_doc = num;
            pasajeroIngresado.nombre = nombre;
            pasajeroIngresado.apellido = apellido;
            pasajeroIngresado.ciudad_procedente = ciudad_procedente.cod_ciudad;
            pasajeroIngresado.pais_procedente= pais_procedente.cod_pais;
            pasajeroIngresado.email = email;
            pasajeroIngresado.fechaNac = fechaNac;
            pasajeroIngresado.genero = genero.tipo;
            

            pasajerosServicios.ValidarPasajeros(pasajeroIngresado);
            pasajero = pasajeroIngresado;
            return true;
        }

        public void RegistrarPasajeroo()
        {
            if (pasajerosServicios.RegistrarPasajero(pasajero))
            {
                MessageBox.Show("El pasajero se registro exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Ocurrio un problema para registrar , intentelo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
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
    }
}

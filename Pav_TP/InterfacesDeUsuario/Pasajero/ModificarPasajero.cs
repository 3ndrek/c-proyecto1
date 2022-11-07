using Pav_TP.Entidades;
using Pav_TP.Servicios;
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

namespace Pav_TP.InterfacesDeUsuario.Pasajero
{
    public partial class ModificarPasajero : Form
    {
        private Entidades.Pasajero pasajero;
        private TipoDocServicios tipoServicio;
        private PasajerosServicios pasajerosServicios;
        private CiudadServicios ciudadServicios;
        private PaisesServicios paisesServicios;
        private GeneroServicios generoServicios;
        
        public ModificarPasajero(int tipo, int id)
        {
            pasajerosServicios = new PasajerosServicios();
            tipoServicio = new TipoDocServicios();
            ciudadServicios = new CiudadServicios();
            paisesServicios = new PaisesServicios();
            generoServicios = new GeneroServicios();
            pasajero = pasajerosServicios.GetPasajeros(tipo,id);
            InitializeComponent();
        }

        private void ModificarPasajero_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarPais();
            CargarGenero();
            CargarDoc();
            this.FormClosed += new FormClosedEventHandler(cerrarForm);
        }

        private void cerrarForm(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CargarDatos()
        {
            comboBoxDni.Text = pasajero.tipo_doc.ToString();
            TxtDni.Text = pasajero.num_doc.ToString();
            TxtNom.Text = pasajero.nombre;
            TxtApe.Text = pasajero.apellido;
            comboBoxCiudad.Text = pasajero.ciudad_procedente.ToString();
            comboBoxPais.Text = pasajero.pais_procedente.ToString();
            TxtEmail.Text = pasajero.email;
            dateTimePicker2.Text = pasajero.fechaNac.ToString();
            comboBoxGenero.Text = pasajero.genero.ToString();
            
        }

        public void CargarDoc()
        {
            var doc = tipoServicio.GetTipos();
            var conector = new BindingSource();
            conector.DataSource = doc;

            comboBoxDni.DataSource = conector;
            comboBoxDni.DisplayMember = "desc";
            comboBoxDni.ValueMember = "tipo";

            var tipoSeleccionada = doc.First(p => p.tipo == pasajero.tipo_doc);
            comboBoxDni.SelectedItem = tipoSeleccionada;
        }

       

        public void CargarPais()
        {
            var p = paisesServicios.GetPaises();
            var conector = new BindingSource();
            conector.DataSource = p;

            comboBoxPais.DataSource = conector;
            comboBoxPais.DisplayMember = "nombre";
            comboBoxPais.ValueMember = "cod_pais";

            var pSeleccionada = p.First(t => t.cod_pais == pasajero.pais_procedente);
            comboBoxPais.SelectedItem = pSeleccionada;
        }
        public void CargarGenero()
        {
            var g = generoServicios.GetGeneros();
            var conector = new BindingSource();
            conector.DataSource = g;

            comboBoxGenero.DataSource = conector;
            comboBoxGenero.DisplayMember = "desc";
            comboBoxGenero.ValueMember = "tipo";

            var gSeleccionada = g.First(p => p.tipo== pasajero.genero);
            comboBoxGenero.SelectedItem = gSeleccionada;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                if (!esPasajeroValido())
                    return;
                ActualizarPasajero();
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


            var pasajeroIngresado = new Entidades.Pasajero();
            pasajeroIngresado.tipo_doc = tipo.tipo;
            pasajeroIngresado.num_doc = num;
            pasajeroIngresado.nombre = nombre;
            pasajeroIngresado.apellido = apellido;
            pasajeroIngresado.ciudad_procedente = ciudad_procedente.cod_ciudad;
            pasajeroIngresado.pais_procedente = pais_procedente.cod_pais;
            pasajeroIngresado.email = email;
            pasajeroIngresado.fechaNac = fechaNac;
            pasajeroIngresado.genero = genero.tipo;


            pasajerosServicios.ValidarPasajeros(pasajeroIngresado);
            pasajero = pasajeroIngresado;
            return true;
        }

        public void ActualizarPasajero()
        {
            pasajerosServicios.ActualizarPasajero(pasajero);
            MessageBox.Show("Se actualizo correctamente el pasajero", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CerrarFormulario()
        {
            this.Dispose();
        }

        private void comboBoxPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var seleccionado = (Paises)comboBoxPais.SelectedItem;
            var ciudades = ciudadServicios.GetCiudades(seleccionado);

            var conector = new BindingSource();
            conector.DataSource = ciudades;

            comboBoxCiudad.DataSource = conector;
            comboBoxCiudad.DisplayMember = "nombre";
            comboBoxCiudad.ValueMember = "cod_ciudad";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }
        
    }
}

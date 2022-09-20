﻿using Pav_TP.Entidades;
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
        
        public ModificarPasajero(int id)
        {
            pasajerosServicios = new PasajerosServicios();
            tipoServicio = new TipoDocServicios();
            ciudadServicios = new CiudadServicios();
            paisesServicios = new PaisesServicios();
            generoServicios = new GeneroServicios();
            pasajero = pasajerosServicios.GetPasajeros(id);
            InitializeComponent();
        }

        private void ModificarPasajero_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarCiudad();
            CargarPais();
            CargarGenero();
        }

        private void CargarDatos()
        {
            TxtNom.Text = pasajero.nombre;
            TxtApe.Text = pasajero.apellido;
            comboBoxCiudad.Text = pasajero.ciudad_procedente.ToString();
            comboBoxPais.Text = pasajero.pais_procedente.ToString();
            TxtEmail.Text = pasajero.email;
            dateTimePicker2.Text = pasajero.ToString();
            comboBoxGenero.Text = pasajero.genero.ToString();
            
        }

        public void CargarCiudad()
        {
            var c = ciudadServicios.GetCiudades();
            var conector = new BindingSource();
            conector.DataSource = c;

            comboBoxCiudad.DataSource = conector;
            comboBoxCiudad.DisplayMember = "nombre";
            comboBoxCiudad.ValueMember = "cod_ciudad";

            var cSeleccionada = c.First(p => p.cod_ciudad == pasajero.ciudad_procedente);
            comboBoxCiudad.SelectedItem = cSeleccionada;
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
            var nombre = TxtNom.Text;
            var apellido = TxtApe.Text.Trim();
            var ciudad_procedente = (Ciudad)comboBoxCiudad.SelectedItem;
            var pais_procedente = (Paises)comboBoxPais.SelectedItem;
            var email = TxtEmail.Text.Trim();
            var fechaNac = Convert.ToDateTime(dateTimePicker2.Text.Trim());
            var genero = (Genero)comboBoxGenero.SelectedItem;


            var pasajeroIngresado = new Entidades.Pasajero();
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
    }
}

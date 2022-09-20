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

namespace Pav_TP.InterfacesDeUsuario.Tripulante
{
    public partial class ModificarTripulante : Form
    {
        private Entidades.Tripulante tripulante;
        private TripulantesServicios tripulantesServicios;
        private PuestosServicios puestosServicios;
        private JefeServicios jefesServicios;
        public ModificarTripulante(int id)
        {
            tripulantesServicios = new TripulantesServicios();
            puestosServicios = new PuestosServicios();
            jefesServicios = new JefeServicios();
            tripulante = tripulantesServicios.GetTripulantes(id);
            InitializeComponent();
        }

        private void ModificarTripulante_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarPuestos();
            CargarJefe();      }

        private void CargarDatos()
        {
            comboBoxJefe.Text = tripulante.jefe.ToString();
            TxtNom.Text = tripulante.nombre;
            TxtApe.Text = tripulante.apellido;
            TxtEmail.Text = tripulante.email;
            dtFechaNac.Text = tripulante.fechaNac.ToString();
            cmbCod.Text = tripulante.puesto.ToString();
            
        }

        public void CargarPuestos()
        {
            var puestos = puestosServicios.GetPuestos();
            var conector = new BindingSource();
            conector.DataSource =puestos;

            cmbCod.DataSource = conector;
            cmbCod.DisplayMember = "desc";
            cmbCod.ValueMember = "cod_puesto";

            var puestoSeleccionada = puestos.First(p => p.cod_puesto == tripulante.puesto);
            cmbCod.SelectedItem = puestoSeleccionada;
        }

        public void CargarJefe()
        {
            var jefe = jefesServicios.GetJefes();
            var jefeDefault = new Entidades.Tripulante();
            jefeDefault.legajo = 0;
            jefeDefault.nombre = "Seleccionar";
            jefe.Add(jefeDefault);
            var conector = new BindingSource();
            conector.DataSource =jefe;

            comboBoxJefe.DataSource = conector;
            comboBoxJefe.DisplayMember = "nombre";
            comboBoxJefe.ValueMember =  "legajo" ;
            comboBoxJefe.SelectedItem = jefeDefault;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                if (!EsTripulanteValido())
                    return;
                ActualizarTripulante();
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

        public bool EsTripulanteValido()
        {
            var jefe = Convert.ToInt32(comboBoxJefe.SelectedItem);
            var nombre = TxtNom.Text;
            var apellido = TxtApe.Text;
            var email = TxtEmail.Text;
            var fechaNac = Convert.ToDateTime(dtFechaNac.Text.Trim());
            var puesto = (Puestos)cmbCod.SelectedItem;

            var tripulanteIngresado = new Entidades.Tripulante();
            tripulanteIngresado.jefe = jefe;
            tripulanteIngresado.nombre = nombre;
            tripulanteIngresado.apellido = apellido;
            tripulanteIngresado.email = email;
            tripulanteIngresado.fechaNac = fechaNac;
            tripulanteIngresado.puesto = puesto.cod_puesto;


            tripulantesServicios.ValidarTripulante(tripulanteIngresado);
            tripulante = tripulanteIngresado;
            return true;
        }

        public void ActualizarTripulante()
        {
            tripulantesServicios.ActualizarTripulante(tripulante);
            MessageBox.Show("Se actualizo correctamente la información de pasajero ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CerrarFormulario()
        {
            this.Dispose();
        }
    }
}

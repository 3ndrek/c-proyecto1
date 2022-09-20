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

namespace TrabajoPracticoPav
{
    public partial class RegistrarTripulante : Form
    {
        private Tripulante tripulante;
        private PuestosServicios puestosServicios;
        private TripulantesServicios tripulantesServicios;
        private ConsultarTripulante consultarTripulante;
        private JefeServicios jefeServicios;

        private readonly FrmPrincipal frmPrincipal;
        private readonly ConsultarTripulante frmConsultarTripulante;
        public RegistrarTripulante(FrmPrincipal frmPrincipal1)
        {
            frmPrincipal = frmPrincipal1;
            tripulantesServicios = new TripulantesServicios();
            puestosServicios = new PuestosServicios();
            jefeServicios = new JefeServicios();
            InitializeComponent();
        }

        public RegistrarTripulante(ConsultarTripulante frmConsultarTripulante)
        {
            frmConsultarTripulante = frmConsultarTripulante;
            tripulantesServicios = new TripulantesServicios();
            puestosServicios = new PuestosServicios();
            jefeServicios = new JefeServicios();
            InitializeComponent();
        }

        private void RegistrarTripulante_Load(object sender, EventArgs e)
        {
            CargarPuesto();
            CargarJefe();
        }

        public void CargarPuesto()
        {
            var puestos = puestosServicios.GetPuestos();
            var puestoSeleccionar = new Puestos();
            puestoSeleccionar.desc = "Seleccionar";
            puestos.Add(puestoSeleccionar);

            var conector = new BindingSource();
            conector.DataSource = puestos;

            cmbCod.DataSource = conector;
            cmbCod.DisplayMember = "desc";
            cmbCod.ValueMember = "cod_puesto";
            cmbCod.SelectedItem = puestoSeleccionar;
        }

        public void CargarJefe()
        {
            var jefe = jefeServicios.GetJefes();
            var jefeDefault = new Tripulante();
            jefeDefault.legajo = 0;
            jefeDefault.nombre = "Seleccionar";
            jefe.Add(jefeDefault);
            var conector = new BindingSource();
            conector.DataSource = jefe;

            comboBoxJefe.DataSource = conector;
            comboBoxJefe.DisplayMember = "nombre";
            comboBoxJefe.ValueMember = "legajo";
            comboBoxJefe.SelectedItem = jefeDefault;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!esOperacionConfirmada())
                    return;
                if (!esTripulanteValido())
                    return;
                RegistrarTripulantee();
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
        public bool esTripulanteValido()
        {
            var jefe = (Tripulante)comboBoxJefe.SelectedItem;
            var nombre = TxtNom.Text;
            var apellido = TxtApe.Text.Trim();
            var email = TxtEmail.Text.Trim();
            var fechaNac = Convert.ToDateTime(dateTimePicker1.Text.Trim());
            var puesto = (Puestos)cmbCod.SelectedItem;


            var tripulanteIngresado = new Tripulante();
            tripulanteIngresado.jefe = jefe.jefe;
            tripulanteIngresado.nombre = nombre;
            tripulanteIngresado.apellido = apellido;
            tripulanteIngresado.email = email;
            tripulanteIngresado. fechaNac = fechaNac;
            tripulanteIngresado.puesto = puesto.cod_puesto;


            tripulantesServicios.ValidarTripulante(tripulanteIngresado);
            tripulante= tripulanteIngresado;
            return true;
        }

        public void RegistrarTripulantee()
        {
            if (tripulantesServicios.RegistrarTripulante(tripulante))
            {
                MessageBox.Show("El tripulante se registro exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Ocurrio un problema para registrar , intentelo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

         private void CerrarFormulario()
        {
            frmPrincipal.Show();
            this.Dispose();

        }

        private void RegistrarTripulante_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarFormulario();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }


        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}

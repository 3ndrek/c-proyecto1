using Pav_TP.Entidades;
using Pav_TP.InterfacesDeUsuario.Tripulante;
using Pav_TP.Servicios;
using PAV1;
using seastar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TrabajoPracticoPav
{
    public partial class ConsultarTripulante : Form
    {
        private TripulantesServicios tripulantesServicios;
        private FrmPrincipal frmPrincipal;
        public ConsultarTripulante(FrmPrincipal frm)

        {
            frmPrincipal = frm;
            tripulantesServicios = new TripulantesServicios();
            InitializeComponent();
        }


        private void ConsultarTripulante_Load(object sender, EventArgs e)
        {
            CargarTripulantes();

        }

        private void CargarTripulantes()
        {
            var t = tripulantesServicios.GetTripulantes();
            GrillaTripulante.Rows.Clear();
            FuncionalidadCargarTripulantes(t);
        }


        private void CargarTripulantes(Tripulante bf)
        {
            var t = tripulantesServicios.GetTripulantes(bf);
            GrillaTripulante.Rows.Clear();
            FuncionalidadCargarTripulantes(t);
        }

        private void FuncionalidadCargarTripulantes(List<Tripulante> t)
        {
            foreach (var tripulante in t)
            {
                var fila = new string[]
                {
                    tripulante.legajo.ToString(),
                    tripulante.jefe.ToString(),
                    tripulante.nombre.ToString(),
                    tripulante.apellido.ToString(),
                    tripulante.email.ToString(),
                    tripulante.fechaNac.ToString(),
                    tripulante.puesto.ToString()
                };
                GrillaTripulante.Rows.Add(fila);
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var buscar = new Tripulante();
            if (Convert.ToInt32(TxtLegajo.Text.Trim()) != 0)
            {
                buscar.legajo = Convert.ToInt32(TxtLegajo.Text.Trim());
                CargarTripulantes(buscar);
                return;
            }
            CargarTripulantes();
        }

        private void genero_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form registrarTripulante = new RegistrarTripulante();
            registrarTripulante.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(GrillaTripulante.SelectedRows[0].Cells["legajo"].Value);
            tripulantesServicios.EliminarTripulante(id);
            GrillaTripulante.Rows.Clear();
            CargarTripulantes();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(GrillaTripulante.SelectedRows[0].Cells["nombre"].Value);

            // this.Hide();
            new ModificarTripulante(id).Show();

            GrillaTripulante.Rows.Clear();
            CargarTripulantes();
        }
    }
}
    

    


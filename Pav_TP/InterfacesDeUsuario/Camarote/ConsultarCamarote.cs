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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pav_TP.InterfacesDeUsuario.Camarote
{
    public partial class ConsultarCamarote : Form
    {
        private readonly CamaroteServicios camaroteServicios;

        private readonly FrmPrincipal frmPrincipal;
        public ConsultarCamarote(FrmPrincipal f)
        {
            camaroteServicios = new CamaroteServicios();
            frmPrincipal = f;
            InitializeComponent();
        }

        private void ConsultarCamarote_Load(object sender, EventArgs e)
        {
            camaroteServicios.CargarBarcos(CmbNavio);
            camaroteServicios.CargarGrillaCamarotes(GrillaCamarotes);
        }

        private void CargarCubierta(int b)
        {
            var cubiertasXBarco = camaroteServicios.GetCubiertas(b);
            var cubiertaDefault = new Cubierta();
            cubiertaDefault.cod_navio = 0;
            cubiertaDefault.desc = "Seleccionar";
            cubiertaDefault.num_cubierta = 0;

            var conector = new BindingSource();
            conector.DataSource = cubiertasXBarco;

            CmbCubierta.DataSource = conector;
            CmbCubierta.DisplayMember = "descripcion";
            CmbCubierta.ValueMember = "num_cubierta";
            CmbCubierta.SelectedItem = cubiertaDefault;
        }

        private void CmbCubierta_Click(object sender, EventArgs e)
        {
            CargarCubierta(Convert.ToInt32(CmbNavio.SelectedValue));
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var cam = new Entidades.Camarote();
                if (CmbNavio.SelectedValue == null || (int)CmbNavio.SelectedValue == 0)
                {
                    CmbNavio.Focus();
                    MessageBox.Show("Ingrese un valor en el campo navio");
                    return;
                }
                else cam.cod_navio = (int)CmbNavio.SelectedValue;
                if (CmbCubierta.SelectedValue == null && CmbNavio.SelectedValue != null)
                {
                    CmbNavio.Focus();
                    MessageBox.Show("Ingrese un valor en el campo cubierta");
                    return;
                }
                else cam.num_cubierta = (int)CmbCubierta.SelectedValue;
                if (!string.IsNullOrEmpty(TxtNro.Text))
                    cam.num_camarote = Convert.ToInt32(TxtNro.Text);
                else cam.num_camarote = 0;

                DataTable datos = camaroteServicios.ConsultarCamarote(cam);
                GrillaCamarotes.DataSource = datos;
            }
            catch (Exception)
            {
                MessageBox.Show("Consulta invalida... Verifique los campos obligatorios", "Error 404", MessageBoxButtons.OK);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Form registrarCamarote = new RegistrarCamarote();
            registrarCamarote.ShowDialog();
            camaroteServicios.CargarGrillaCamarotes(GrillaCamarotes);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow lis in GrillaCamarotes.Rows)
            {
                if (Convert.ToBoolean(lis.Cells[7].Value) == true)
                {
                    var cTemp = new Pav_TP.Entidades.Camarote();
                    //Si se busca el camarote, las columnas de la grilla que referencian cod_navio y num_Cubierta valen null en la grilla
                    //Habria que hacer una condicion y seleccionar los datos de la grilla si no se busco nada
                    //o del cmb si se apreto el boton buscar

                    cTemp.cod_navio = Convert.ToInt32(lis.Cells[0].Value.ToString());
                    cTemp.num_cubierta = Convert.ToInt32(lis.Cells[1].Value.ToString());
                    cTemp.num_camarote = Convert.ToInt32(lis.Cells[2].Value.ToString());

                    
                    camaroteServicios.EliminarCamarote(cTemp);
                    
                    //Agregar pregunta: Esta seguro de que desea eliminar este camarote?

                }
            }
            camaroteServicios.CargarGrillaCamarotes(GrillaCamarotes);
        }

        private void CerrarFormulario()
        {
            frmPrincipal.Show();
            this.Dispose();
        }

        private void ConsultarCamarote_FormClosing(object sender, FormClosingEventArgs e)
        {
                CerrarFormulario();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
                CerrarFormulario();
        }
    }
}

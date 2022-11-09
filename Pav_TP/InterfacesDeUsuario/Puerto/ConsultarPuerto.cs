using Pav_TP.Entidades;
using Pav_TP.InterfacesDeUsuario.Barco;
using Pav_TP.Servicios;
using seastar;
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
    public partial class ConsultarPuerto : Form
    {
        private FrmPrincipal frmPrincipal;
        private PuertosServicios puertosServicios;
        public ConsultarPuerto()
        {
            puertosServicios = new PuertosServicios();
            InitializeComponent();
        }

        private void ConsultarPuerto_Load(object sender, EventArgs e)
        {
            CargarPuertos();
        }
        private void CargarPuertos()
        {
            var puertos = puertosServicios.GetPuertos();
            DgvPuerto.Rows.Clear();
            FuncionalidadCargarPuertos(puertos);
        }
        private void CargarPuertos(Entidades.Puerto pf)
        {
            var puertos = puertosServicios.GetPuertos(pf);
            DgvPuerto.Rows.Clear();
            FuncionalidadCargarPuertos(puertos);
        }

        private void FuncionalidadCargarPuertos(List<Entidades.Puerto> puertos)
        {
            foreach (var puerto in puertos)
            {
                var fila = new string[]
                {
                    puerto.Codigo.ToString(),
                    puerto.Nombre.ToString()
                };
                DgvPuerto.Rows.Add(fila);
            }
        }

        private void BtnFiltro_Click(object sender, EventArgs e)
        {
            var puertoFiltro = new Entidades.Puerto();
            if (Convert.ToInt32(TxtFiltroCodigo.Text.Trim()) != 0)
                puertoFiltro.Codigo = Convert.ToInt32(TxtFiltroCodigo.Text.Trim());
            puertoFiltro.Nombre = TxtFiltroNombre.Text.Trim();
            if (Convert.ToInt32(TxtFiltroCodigo.Text.Trim()) != 0 || TxtFiltroNombre.Text.Trim() != null)
            {
                CargarPuertos(puertoFiltro);
                return;
            }
            CargarPuertos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(DgvPuerto.SelectedRows[0].Cells["Codigo"].Value);
            puertosServicios.EliminarPuerto(id);
            DgvPuerto.Rows.Clear();
            CargarPuertos();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegistrarPuerto().Show();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(DgvPuerto.SelectedRows[0].Cells["Codigo"].Value);

            // this.Hide();
            new ModificarPuerto(id).Show();
            DgvPuerto.Rows.Clear();
            CargarPuertos();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal.Show();
        }
    }
}

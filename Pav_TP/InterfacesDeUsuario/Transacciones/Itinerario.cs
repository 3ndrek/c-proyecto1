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

namespace Pav_TP.InterfacesDeUsuario.Transacciones
{
    public partial class Itinerario : Form
    {
        private readonly ItinerarioServicios itinerarioServicios;
        
        public Itinerario()
        {
            itinerarioServicios = new ItinerarioServicios();
            InitializeComponent();
        }

        private void Itinerario_Load(object sender, EventArgs e)
        {
            itinerarioServicios.CargarPaises(cmbPais);
            itinerarioServicios.CargarCategorias(cmbCategoria);
            CargarDgv();
        }

        private void CargarPuertosXPais(int cod_pais)
        {
            var puertosXpaises = itinerarioServicios.GetPuertosXPais(cod_pais);
            var puertoDefault = new Pav_TP.Entidades.Puertos();
            puertoDefault.cod_puerto = 0;
            puertoDefault.nombre = "Seleccionar";

            var conector = new BindingSource();
            conector.DataSource = puertosXpaises;

            cmbPuerto.DataSource = conector;
            cmbPuerto.DisplayMember = "nombre";
            cmbPuerto.ValueMember = "cod_puerto";
            cmbPuerto.SelectedItem = puertoDefault;

        }

        private void cmbPuerto_Click(object sender, EventArgs e)
        {
            CargarPuertosXPais(Convert.ToInt32(cmbPais.SelectedValue));
        }

        private void CargarDgv()
        {
            dgvPuertos.ColumnCount = 3;
            dgvPuertos.Columns[0].Name = "Pais";
            dgvPuertos.Columns[1].Name = "Puertos";
            dgvPuertos.Columns[2].Name = "Nro Escala";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string[] row = { $"{cmbPais.SelectedValue}", $"{cmbPuerto.SelectedValue}", $"{txtEscala.Text}" };

            dgvPuertos.Rows.Add(row);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int cod_i = itinerarioServicios.GenerarCodItinerario();
            int cat = Convert.ToInt32(cmbCategoria.SelectedValue);
            itinerarioServicios.RegistrarItinerario(cod_i,cat);
            itinerarioServicios.RegistrarPuertosXItinerario(dgvPuertos, cod_i);
            MessageBox.Show("El itinerario se registro con exito...");
        }
    }
}

/*Hay que filtrar la busqueda de puertos por pais
             * Despues hay que generar un data source al data grid view con los puertos que se agruegen
             * Habria que ver si el nro de escala se los dejamos agruegar al usuario o se hace incremental
             * La categoria itinerario hay que sacarla de la bd (Con un dataSet?) o con una consulta y un binding source
             * Con eso tamos...
            */

/*
 private void SetupDataGridView()
    {
        this.Controls.Add(songsDataGridView);

        songsDataGridView.ColumnCount = 5;

        songsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
        songsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        songsDataGridView.ColumnHeadersDefaultCellStyle.Font =
            new Font(songsDataGridView.Font, FontStyle.Bold);

        songsDataGridView.Name = "songsDataGridView";
        songsDataGridView.Location = new Point(8, 8);
        songsDataGridView.Size = new Size(500, 250);
        songsDataGridView.AutoSizeRowsMode =
            DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
        songsDataGridView.ColumnHeadersBorderStyle =
            DataGridViewHeaderBorderStyle.Single;
        songsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        songsDataGridView.GridColor = Color.Black;
        songsDataGridView.RowHeadersVisible = false;

        songsDataGridView.Columns[0].Name = "Release Date";
        songsDataGridView.Columns[1].Name = "Track";
        songsDataGridView.Columns[2].Name = "Title";
        songsDataGridView.Columns[3].Name = "Artist";
        songsDataGridView.Columns[4].Name = "Album";
        songsDataGridView.Columns[4].DefaultCellStyle.Font =
            new Font(songsDataGridView.DefaultCellStyle.Font, FontStyle.Italic);

        songsDataGridView.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
        songsDataGridView.MultiSelect = false;
        songsDataGridView.Dock = DockStyle.Fill;

        songsDataGridView.CellFormatting += new
            DataGridViewCellFormattingEventHandler(
            songsDataGridView_CellFormatting);
    }
 */


/*
 private void PopulateDataGridView()
    {

        string[] row0 = { "11/22/1968", "29", "Revolution 9", 
            "Beatles", "The Beatles [White Album]" };
        string[] row1 = { "1960", "6", "Fools Rush In", 
            "Frank Sinatra", "Nice 'N' Easy" };
        string[] row2 = { "11/11/1971", "1", "One of These Days", 
            "Pink Floyd", "Meddle" };
        string[] row3 = { "1988", "7", "Where Is My Mind?", 
            "Pixies", "Surfer Rosa" };
        string[] row4 = { "5/1981", "9", "Can't Find My Mind", 
            "Cramps", "Psychedelic Jungle" };
        string[] row5 = { "6/10/2003", "13", 
            "Scatterbrain. (As Dead As Leaves.)", 
            "Radiohead", "Hail to the Thief" };
        string[] row6 = { "6/30/1992", "3", "Dress", "P J Harvey", "Dry" };

        songsDataGridView.Rows.Add(row0);
        songsDataGridView.Rows.Add(row1);
        songsDataGridView.Rows.Add(row2);
        songsDataGridView.Rows.Add(row3);
        songsDataGridView.Rows.Add(row4);
        songsDataGridView.Rows.Add(row5);
        songsDataGridView.Rows.Add(row6);

        songsDataGridView.Columns[0].DisplayIndex = 3;
        songsDataGridView.Columns[1].DisplayIndex = 4;
        songsDataGridView.Columns[2].DisplayIndex = 0;
        songsDataGridView.Columns[3].DisplayIndex = 1;
        songsDataGridView.Columns[4].DisplayIndex = 2;
    }

 */


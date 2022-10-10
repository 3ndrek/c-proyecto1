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
        //private DataTable puertos;
        
        public Itinerario()
        {
            itinerarioServicios = new ItinerarioServicios();
            /*puertos = new DataTable();
            puertos.Rows.Add("Pais", typeof(String));
            puertos.Rows.Add("NombrePuerto", typeof (String));
            puertos.Rows.Add("NumeroEscala", typeof(Int32));*/
            InitializeComponent();
        }

        private void Itinerario_Load(object sender, EventArgs e)
        {
            itinerarioServicios.CargarPaises(cmbPais);
            itinerarioServicios.CargarCategorias(cmbCategoria);
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
        /*private Pav_TP.Entidades.Puertos ArmarEscala()
        {
            var puerto = new Pav_TP.Entidades.Puertos();
            puerto.cod_puerto = Convert.ToInt32(cmbPuerto.SelectedValue);
            puerto.nombre = cmbPuerto.DisplayMember;
            return puerto;
        }*/

        private void CargarPuertos()
        {
            
            
        
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CargarPuertos();
        }
    }
}

/*Hay que filtrar la busqueda de puertos por pais
             * Despues hay que generar un data source al data grid view con los puertos que se agruegen
             * Habria que ver si el nro de escala se los dejamos agruegar al usuario o se hace incremental
             * La categoria itinerario hay que sacarla de la bd (Con un dataSet?) o con una consulta y un binding source
             * Con eso tamos...
            */
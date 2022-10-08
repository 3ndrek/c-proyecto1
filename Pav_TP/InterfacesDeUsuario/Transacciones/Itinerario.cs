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
        public Itinerario()
        {
            InitializeComponent();
        }

        private void Itinerario_Load(object sender, EventArgs e)
        {
            /*Hay que filtrar la busqueda de puertos por pais
             * Despues hay que generar un data source al data grid view con los puertos que se agruegen
             * Habria que ver si el nro de escala se los dejamos agruegar al usuario o se hace incremental
             * La categoria itinerario hay que sacarla de la bd (Con un dataSet?) o con una consulta y un binding source
             * Con eso tamos...
            */
        }
    }
}

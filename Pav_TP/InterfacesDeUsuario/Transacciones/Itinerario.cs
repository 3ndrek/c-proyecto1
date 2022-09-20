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
            // TODO: This line of code loads data into the 'pAV_3K2_2022_12DataSet2.puertos' table. You can move, or remove it, as needed.
            this.puertosTableAdapter.Fill(this.pAV_3K2_2022_12DataSet2.puertos);

        }
    }
}

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
    public partial class RegistrarPuerto : Form
    {
        public RegistrarPuerto()
        {
            InitializeComponent();
        }

        private void RegistrarPuerto_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal.Show();
        }
    }
}

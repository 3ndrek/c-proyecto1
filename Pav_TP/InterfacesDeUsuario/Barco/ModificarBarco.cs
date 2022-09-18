using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pav_TP.InterfacesDeUsuario;
using seastar;

namespace Pav_TP.InterfacesDeUsuario.Barco
{
    public partial class ModificarBarco : Form
    {
        public ModificarBarco()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Hide();
        }
    }
}

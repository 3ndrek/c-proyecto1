﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using seastar;

namespace PAV1
{
    public partial class ConsultarViaje : Form
    {
        public ConsultarViaje()
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

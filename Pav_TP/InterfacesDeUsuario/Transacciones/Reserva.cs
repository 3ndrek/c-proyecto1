﻿using seastar;
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
    public partial class Reserva : Form
    {
        private static FrmPrincipal frmPrincipal;

        public Reserva(FrmPrincipal Principal)
        {
            frmPrincipal = Principal;

            InitializeComponent();
        }

        private void Reserva_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pAV_3K2_2022_12DataSet4.camarotes' table. You can move, or remove it, as needed.
            this.camarotesTableAdapter.Fill(this.pAV_3K2_2022_12DataSet4.camarotes);
            // TODO: This line of code loads data into the 'pAV_3K2_2022_12DataSet3.viaje' table. You can move, or remove it, as needed.
            this.viajeTableAdapter.Fill(this.pAV_3K2_2022_12DataSet3.viaje);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Reserva_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            frmPrincipal.Show();
        }
    }
}

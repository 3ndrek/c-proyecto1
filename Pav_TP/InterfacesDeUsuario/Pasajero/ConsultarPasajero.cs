﻿using Pav_TP.Entidades;
using Pav_TP.Servicios;
using PAV1;
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

namespace TrabajoPracticoPav
{
    public partial class ConsultarPasajero : Form
    {
        private PasajerosServicios pasajerosServicios;
        private FrmPrincipal frmPrincipal;
        public ConsultarPasajero(FrmPrincipal frm)

        {
            frmPrincipal = frm;
            pasajerosServicios = new PasajerosServicios();
            InitializeComponent();
        }


        private void ConsultarPasajero_Load(object sender, EventArgs e)
        {
            CargarPasajeros();
        }

        private void CargarPasajeros()
        {
            var pasajeros = pasajerosServicios.GetPasajeros();
            GrillaPasajero.Rows.Clear();
            FuncionalidadCargarPasajeros(pasajeros);
        }
        private void CargarPasajeros(Pasajero bf)
        {
            var pasajeros = pasajerosServicios.GetPasajeros(bf);
            GrillaPasajero.Rows.Clear();
            FuncionalidadCargarPasajeros(pasajeros);
        }

        private void FuncionalidadCargarPasajeros(List<Pasajero> t)
        {
            foreach (var pasajero in t)
            {
                var fila = new string[]
                {
                    pasajero.tipo_doc.ToString(),
                    pasajero.num_doc.ToString(),
                    pasajero.nombre.ToString(),
                    pasajero.apellido.ToString(),
                    pasajero.ciudad_procedente.ToString(),
                    pasajero.pais_procedente.ToString(),
                    pasajero.email.ToString(),
                    pasajero.fechaNac.ToString(),
                    pasajero.genero.ToString()
                };
                GrillaPasajero.Rows.Add(fila);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegistrarPasajero(frmPrincipal).Show();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(GrillaPasajero.SelectedRows[0].Cells["num_doc"].Value);

            // this.Hide();
            new ModificarPasajero(id).Show();
            GrillaPasajero.Rows.Clear();
            CargarPasajeros();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(GrillaPasajero.SelectedRows[0].Cells["num_doc"].Value);
            pasajerosServicios.EliminarPasajero(id);
            GrillaPasajero.Rows.Clear();
            CargarPasajeros();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var buscar = new Pasajero();
            if (Convert.ToInt32(TxtDni.Text.Trim()) != 0)
            {
                buscar.num_doc = Convert.ToInt32(TxtDni.Text.Trim());
                CargarPasajeros(buscar);
                return;
            }
            CargarPasajeros();
            
        }


    }
}

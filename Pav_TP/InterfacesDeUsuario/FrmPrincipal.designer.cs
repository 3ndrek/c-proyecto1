﻿namespace seastar
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.barcoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarBarco = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarBarco = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.cubiertaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCubierta = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCubierta = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCubierta = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCubierta = new System.Windows.Forms.ToolStripMenuItem();
            this.camaroteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCamaroteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCamaroteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCamaroteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.viajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarViajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarViajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarViajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itinerarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.puertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPuerto = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPuerto = new System.Windows.Forms.ToolStripMenuItem();
            this.pasajeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPasajero = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(109)))), ((int)(((byte)(182)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barcoToolStripMenuItem,
            this.camaroteToolStripMenuItem1,
            this.puertoToolStripMenuItem,
            this.viajesToolStripMenuItem,
            this.reservaToolStripMenuItem,
            this.itinerarioToolStripMenuItem,
            this.pasajeroToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(721, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // barcoToolStripMenuItem
            // 
            this.barcoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarBarco,
            this.consultarBarco,
            this.eliminarToolStripMenuItem,
            this.cubiertaToolStripMenuItem1});
            this.barcoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcoToolStripMenuItem.Name = "barcoToolStripMenuItem";
            this.barcoToolStripMenuItem.Size = new System.Drawing.Size(61, 25);
            this.barcoToolStripMenuItem.Text = "Barco";
            // 
            // registrarBarco
            // 
            this.registrarBarco.Name = "registrarBarco";
            this.registrarBarco.Size = new System.Drawing.Size(190, 26);
            this.registrarBarco.Text = "Registrar barco";
            this.registrarBarco.Click += new System.EventHandler(this.registrarBarco_Click_1);
            // 
            // consultarBarco
            // 
            this.consultarBarco.Name = "consultarBarco";
            this.consultarBarco.Size = new System.Drawing.Size(190, 26);
            this.consultarBarco.Text = "Consultar barco";
            this.consultarBarco.Click += new System.EventHandler(this.consultarBarco_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(187, 6);
            // 
            // cubiertaToolStripMenuItem1
            // 
            this.cubiertaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarCubierta,
            this.registrarCubierta,
            this.modificarCubierta,
            this.eliminarCubierta});
            this.cubiertaToolStripMenuItem1.Name = "cubiertaToolStripMenuItem1";
            this.cubiertaToolStripMenuItem1.Size = new System.Drawing.Size(190, 26);
            this.cubiertaToolStripMenuItem1.Text = "Cubierta";
            this.cubiertaToolStripMenuItem1.Click += new System.EventHandler(this.cubiertaToolStripMenuItem1_Click);
            // 
            // consultarCubierta
            // 
            this.consultarCubierta.Name = "consultarCubierta";
            this.consultarCubierta.Size = new System.Drawing.Size(180, 26);
            this.consultarCubierta.Text = "Consultar";
            this.consultarCubierta.Click += new System.EventHandler(this.consultarCubierta_Click);
            // 
            // registrarCubierta
            // 
            this.registrarCubierta.Name = "registrarCubierta";
            this.registrarCubierta.Size = new System.Drawing.Size(180, 26);
            this.registrarCubierta.Text = "Registrar";
            this.registrarCubierta.Click += new System.EventHandler(this.registrarCubierta_Click);
            // 
            // modificarCubierta
            // 
            this.modificarCubierta.Name = "modificarCubierta";
            this.modificarCubierta.Size = new System.Drawing.Size(180, 26);
            this.modificarCubierta.Text = "Modificar";
            this.modificarCubierta.Click += new System.EventHandler(this.modificarCubierta_Click);
            // 
            // eliminarCubierta
            // 
            this.eliminarCubierta.Name = "eliminarCubierta";
            this.eliminarCubierta.Size = new System.Drawing.Size(180, 26);
            this.eliminarCubierta.Text = "Eliminar";
            this.eliminarCubierta.Click += new System.EventHandler(this.eliminarCubierta_Click);
            // 
            // camaroteToolStripMenuItem1
            // 
            this.camaroteToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCamaroteToolStripMenuItem,
            this.consultarCamaroteToolStripMenuItem,
            this.modificarCamaroteToolStripMenuItem});
            this.camaroteToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camaroteToolStripMenuItem1.Name = "camaroteToolStripMenuItem1";
            this.camaroteToolStripMenuItem1.Size = new System.Drawing.Size(90, 25);
            this.camaroteToolStripMenuItem1.Text = "Camarote";
            // 
            // registrarCamaroteToolStripMenuItem
            // 
            this.registrarCamaroteToolStripMenuItem.Name = "registrarCamaroteToolStripMenuItem";
            this.registrarCamaroteToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.registrarCamaroteToolStripMenuItem.Text = "Registrar Camarote";
            this.registrarCamaroteToolStripMenuItem.Click += new System.EventHandler(this.registrarCamaroteToolStripMenuItem_Click);
            // 
            // consultarCamaroteToolStripMenuItem
            // 
            this.consultarCamaroteToolStripMenuItem.Name = "consultarCamaroteToolStripMenuItem";
            this.consultarCamaroteToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.consultarCamaroteToolStripMenuItem.Text = "Consultar Camarote";
            this.consultarCamaroteToolStripMenuItem.Click += new System.EventHandler(this.consultarCamaroteToolStripMenuItem_Click);
            // 
            // modificarCamaroteToolStripMenuItem
            // 
            this.modificarCamaroteToolStripMenuItem.Name = "modificarCamaroteToolStripMenuItem";
            this.modificarCamaroteToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.modificarCamaroteToolStripMenuItem.Text = "Modificar Camarote";
            this.modificarCamaroteToolStripMenuItem.Click += new System.EventHandler(this.modificarCamaroteToolStripMenuItem_Click);
            // 
            // puertoToolStripMenuItem
            // 
            this.puertoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem2,
            this.consultarToolStripMenuItem4});
            this.puertoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puertoToolStripMenuItem.Name = "puertoToolStripMenuItem";
            this.puertoToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.puertoToolStripMenuItem.Text = "Tripulante";
            this.puertoToolStripMenuItem.Click += new System.EventHandler(this.puertoToolStripMenuItem_Click);
            // 
            // registrarToolStripMenuItem2
            // 
            this.registrarToolStripMenuItem2.Name = "registrarToolStripMenuItem2";
            this.registrarToolStripMenuItem2.Size = new System.Drawing.Size(227, 26);
            this.registrarToolStripMenuItem2.Text = "Registrar Tripulante";
            this.registrarToolStripMenuItem2.Click += new System.EventHandler(this.registrarToolStripMenuItem2_Click);
            // 
            // consultarToolStripMenuItem4
            // 
            this.consultarToolStripMenuItem4.Name = "consultarToolStripMenuItem4";
            this.consultarToolStripMenuItem4.Size = new System.Drawing.Size(227, 26);
            this.consultarToolStripMenuItem4.Text = "Consultar Tripulantes";
            this.consultarToolStripMenuItem4.Click += new System.EventHandler(this.consultarToolStripMenuItem4_Click);
            // 
            // viajesToolStripMenuItem
            // 
            this.viajesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarViajeToolStripMenuItem,
            this.consultarViajeToolStripMenuItem,
            this.eliminarViajeToolStripMenuItem});
            this.viajesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viajesToolStripMenuItem.Name = "viajesToolStripMenuItem";
            this.viajesToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.viajesToolStripMenuItem.Text = "Viajes";
            // 
            // generarViajeToolStripMenuItem
            // 
            this.generarViajeToolStripMenuItem.Name = "generarViajeToolStripMenuItem";
            this.generarViajeToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.generarViajeToolStripMenuItem.Text = "Registrar Viaje";
            this.generarViajeToolStripMenuItem.Click += new System.EventHandler(this.generarViajeToolStripMenuItem_Click);
            // 
            // consultarViajeToolStripMenuItem
            // 
            this.consultarViajeToolStripMenuItem.Name = "consultarViajeToolStripMenuItem";
            this.consultarViajeToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.consultarViajeToolStripMenuItem.Text = "Consultar Viaje";
            this.consultarViajeToolStripMenuItem.Click += new System.EventHandler(this.consultarViajeToolStripMenuItem_Click);
            // 
            // eliminarViajeToolStripMenuItem
            // 
            this.eliminarViajeToolStripMenuItem.Name = "eliminarViajeToolStripMenuItem";
            this.eliminarViajeToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            // 
            // reservaToolStripMenuItem
            // 
            this.reservaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.cobrarToolStripMenuItem});
            this.reservaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            this.reservaToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.reservaToolStripMenuItem.Text = "Reserva";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.registrarToolStripMenuItem.Text = "Registrar Reserva";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // cobrarToolStripMenuItem
            // 
            this.cobrarToolStripMenuItem.Name = "cobrarToolStripMenuItem";
            this.cobrarToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.cobrarToolStripMenuItem.Text = "Cobrar";
            this.cobrarToolStripMenuItem.Click += new System.EventHandler(this.cobrarToolStripMenuItem_Click);
            // 
            // itinerarioToolStripMenuItem
            // 
            this.itinerarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem1,
            this.modificarToolStripMenuItem3,
            this.consultarToolStripMenuItem3,
            this.eliminarToolStripMenuItem3,
            this.toolStripSeparator1,
            this.puertosToolStripMenuItem});
            this.itinerarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itinerarioToolStripMenuItem.Name = "itinerarioToolStripMenuItem";
            this.itinerarioToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.itinerarioToolStripMenuItem.Text = "Itinerario";
            this.itinerarioToolStripMenuItem.Click += new System.EventHandler(this.itinerarioToolStripMenuItem_Click);
            // 
            // registrarToolStripMenuItem1
            // 
            this.registrarToolStripMenuItem1.Name = "registrarToolStripMenuItem1";
            this.registrarToolStripMenuItem1.Size = new System.Drawing.Size(214, 26);
            this.registrarToolStripMenuItem1.Text = "Registrar Itinerario";
            this.registrarToolStripMenuItem1.Click += new System.EventHandler(this.registrarToolStripMenuItem1_Click);
            // 
            // modificarToolStripMenuItem3
            // 
            this.modificarToolStripMenuItem3.Name = "modificarToolStripMenuItem3";
            this.modificarToolStripMenuItem3.Size = new System.Drawing.Size(214, 26);
            this.modificarToolStripMenuItem3.Text = "Modificar Itinerario";
            // 
            // consultarToolStripMenuItem3
            // 
            this.consultarToolStripMenuItem3.Name = "consultarToolStripMenuItem3";
            this.consultarToolStripMenuItem3.Size = new System.Drawing.Size(214, 26);
            this.consultarToolStripMenuItem3.Text = "Consultar Itinerario";
            // 
            // eliminarToolStripMenuItem3
            // 
            this.eliminarToolStripMenuItem3.Name = "eliminarToolStripMenuItem3";
            this.eliminarToolStripMenuItem3.Size = new System.Drawing.Size(214, 26);
            this.eliminarToolStripMenuItem3.Text = "Eliminar Itinerario";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // puertosToolStripMenuItem
            // 
            this.puertosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPuerto,
            this.consultarPuerto});
            this.puertosToolStripMenuItem.Name = "puertosToolStripMenuItem";
            this.puertosToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.puertosToolStripMenuItem.Text = "Gestionar puertos";
            // 
            // registrarPuerto
            // 
            this.registrarPuerto.Name = "registrarPuerto";
            this.registrarPuerto.Size = new System.Drawing.Size(147, 26);
            this.registrarPuerto.Text = "Registrar";
            this.registrarPuerto.Click += new System.EventHandler(this.registrarPuerto_Click);
            // 
            // consultarPuerto
            // 
            this.consultarPuerto.Name = "consultarPuerto";
            this.consultarPuerto.Size = new System.Drawing.Size(147, 26);
            this.consultarPuerto.Text = "Consultar";
            this.consultarPuerto.Click += new System.EventHandler(this.consultarPuerto_Click);
            // 
            // pasajeroToolStripMenuItem
            // 
            this.pasajeroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem3,
            this.consultarPasajero});
            this.pasajeroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasajeroToolStripMenuItem.Name = "pasajeroToolStripMenuItem";
            this.pasajeroToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.pasajeroToolStripMenuItem.Text = "Pasajero";
            // 
            // registrarToolStripMenuItem3
            // 
            this.registrarToolStripMenuItem3.Name = "registrarToolStripMenuItem3";
            this.registrarToolStripMenuItem3.Size = new System.Drawing.Size(209, 26);
            this.registrarToolStripMenuItem3.Text = "Registrar Pasajero";
            this.registrarToolStripMenuItem3.Click += new System.EventHandler(this.registrarToolStripMenuItem3_Click);
            // 
            // consultarPasajero
            // 
            this.consultarPasajero.Name = "consultarPasajero";
            this.consultarPasajero.Size = new System.Drawing.Size(209, 26);
            this.consultarPasajero.Text = "Consultar Pasajero";
            this.consultarPasajero.Click += new System.EventHandler(this.consultarPasajero_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarReportesToolStripMenuItem});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // gestionarReportesToolStripMenuItem
            // 
            this.gestionarReportesToolStripMenuItem.Name = "gestionarReportesToolStripMenuItem";
            this.gestionarReportesToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.gestionarReportesToolStripMenuItem.Text = "Gestionar reportes";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarContraseñaToolStripMenuItem,
            this.perfilToolStripMenuItem,
            this.cambiarUsuarioToolStripMenuItem});
            this.usuarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.cambiarContraseñaToolStripMenuItem.Text = "Modificar Usuario";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.perfilToolStripMenuItem.Text = "Registrar Usuario";
            this.perfilToolStripMenuItem.Click += new System.EventHandler(this.perfilToolStripMenuItem_Click);
            // 
            // cambiarUsuarioToolStripMenuItem
            // 
            this.cambiarUsuarioToolStripMenuItem.Name = "cambiarUsuarioToolStripMenuItem";
            this.cambiarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.cambiarUsuarioToolStripMenuItem.Text = "Consultar Usuario";
            this.cambiarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cambiarUsuarioToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "¡Bienvenido!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LblUsuario.Location = new System.Drawing.Point(145, 60);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(72, 24);
            this.LblUsuario.TabIndex = 6;
            this.LblUsuario.Text = "label3 ";
            this.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(109)))), ((int)(((byte)(182)))));
            this.btnCerrarSesion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(109)))), ((int)(((byte)(182)))));
            this.btnCerrarSesion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCerrarSesion.BorderRadius = 20;
            this.btnCerrarSesion.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(538, 357);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(150, 40);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextColor = System.Drawing.Color.White;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.pruebaButton1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(721, 432);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itinerarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puertoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasajeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem consultarPasajero;
        private System.Windows.Forms.ToolStripMenuItem barcoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarBarco;
        private System.Windows.Forms.ToolStripMenuItem consultarBarco;
        private System.Windows.Forms.ToolStripSeparator eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cubiertaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarCubierta;
        private System.Windows.Forms.ToolStripMenuItem viajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarViajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem puertosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarUsuarioToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem registrarCubierta;
        private System.Windows.Forms.ToolStripMenuItem modificarCubierta;
        private System.Windows.Forms.ToolStripMenuItem eliminarCubierta;
        private System.Windows.Forms.ToolStripMenuItem consultarViajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarViajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPuerto;
        private System.Windows.Forms.ToolStripMenuItem consultarPuerto;
        private System.Windows.Forms.ToolStripMenuItem camaroteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registrarCamaroteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCamaroteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCamaroteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobrarToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblUsuario;
        private Pav_TP.InterfacesDeUsuario.PruebaButton btnCerrarSesion;
    }
}


namespace seastar
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.barcoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarBarco = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarBarco = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.camaroteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultarBarco = new System.Windows.Forms.ToolStripMenuItem();
            this.cubiertaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCubierta = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCubierta = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCubierta = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCubierta = new System.Windows.Forms.ToolStripMenuItem();
            this.puertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.viajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarViajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarViajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarViajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarViajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itinerarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.puertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasajeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPasajero = new System.Windows.Forms.ToolStripMenuItem();
            this.reservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barcoToolStripMenuItem,
            this.puertoToolStripMenuItem,
            this.viajesToolStripMenuItem,
            this.itinerarioToolStripMenuItem,
            this.pasajeroToolStripMenuItem,
            this.reservacionesToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // barcoToolStripMenuItem
            // 
            this.barcoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarBarco,
            this.consultarBarco,
            this.eliminarToolStripMenuItem,
            this.camaroteToolStripMenuItem,
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
            // camaroteToolStripMenuItem
            // 
            this.camaroteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConsultarBarco});
            this.camaroteToolStripMenuItem.Name = "camaroteToolStripMenuItem";
            this.camaroteToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.camaroteToolStripMenuItem.Text = "Camarote";
            // 
            // btnConsultarBarco
            // 
            this.btnConsultarBarco.Name = "btnConsultarBarco";
            this.btnConsultarBarco.Size = new System.Drawing.Size(147, 26);
            this.btnConsultarBarco.Text = "Consultar";
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
            this.registrarToolStripMenuItem2.Size = new System.Drawing.Size(147, 26);
            this.registrarToolStripMenuItem2.Text = "Registrar";
            this.registrarToolStripMenuItem2.Click += new System.EventHandler(this.registrarToolStripMenuItem2_Click);
            // 
            // consultarToolStripMenuItem4
            // 
            this.consultarToolStripMenuItem4.Name = "consultarToolStripMenuItem4";
            this.consultarToolStripMenuItem4.Size = new System.Drawing.Size(147, 26);
            this.consultarToolStripMenuItem4.Text = "Consultar";
            this.consultarToolStripMenuItem4.Click += new System.EventHandler(this.consultarToolStripMenuItem4_Click);
            // 
            // viajesToolStripMenuItem
            // 
            this.viajesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarViajeToolStripMenuItem,
            this.consultarViajeToolStripMenuItem,
            this.modificarViajeToolStripMenuItem,
            this.eliminarViajeToolStripMenuItem});
            this.viajesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viajesToolStripMenuItem.Name = "viajesToolStripMenuItem";
            this.viajesToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.viajesToolStripMenuItem.Text = "Viajes";
            // 
            // generarViajeToolStripMenuItem
            // 
            this.generarViajeToolStripMenuItem.Name = "generarViajeToolStripMenuItem";
            this.generarViajeToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.generarViajeToolStripMenuItem.Text = "Registrar viaje";
            this.generarViajeToolStripMenuItem.Click += new System.EventHandler(this.generarViajeToolStripMenuItem_Click);
            // 
            // consultarViajeToolStripMenuItem
            // 
            this.consultarViajeToolStripMenuItem.Name = "consultarViajeToolStripMenuItem";
            this.consultarViajeToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.consultarViajeToolStripMenuItem.Text = "Consultar viaje";
            this.consultarViajeToolStripMenuItem.Click += new System.EventHandler(this.consultarViajeToolStripMenuItem_Click);
            // 
            // modificarViajeToolStripMenuItem
            // 
            this.modificarViajeToolStripMenuItem.Name = "modificarViajeToolStripMenuItem";
            this.modificarViajeToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.modificarViajeToolStripMenuItem.Text = "Modificar viaje";
            this.modificarViajeToolStripMenuItem.Click += new System.EventHandler(this.modificarViajeToolStripMenuItem_Click);
            // 
            // eliminarViajeToolStripMenuItem
            // 
            this.eliminarViajeToolStripMenuItem.Name = "eliminarViajeToolStripMenuItem";
            this.eliminarViajeToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.eliminarViajeToolStripMenuItem.Text = "Eliminar viaje";
            this.eliminarViajeToolStripMenuItem.Click += new System.EventHandler(this.eliminarViajeToolStripMenuItem_Click);
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
            // 
            // registrarToolStripMenuItem1
            // 
            this.registrarToolStripMenuItem1.Name = "registrarToolStripMenuItem1";
            this.registrarToolStripMenuItem1.Size = new System.Drawing.Size(204, 26);
            this.registrarToolStripMenuItem1.Text = "Registrar";
            // 
            // modificarToolStripMenuItem3
            // 
            this.modificarToolStripMenuItem3.Name = "modificarToolStripMenuItem3";
            this.modificarToolStripMenuItem3.Size = new System.Drawing.Size(204, 26);
            this.modificarToolStripMenuItem3.Text = "Modificar";
            // 
            // consultarToolStripMenuItem3
            // 
            this.consultarToolStripMenuItem3.Name = "consultarToolStripMenuItem3";
            this.consultarToolStripMenuItem3.Size = new System.Drawing.Size(204, 26);
            this.consultarToolStripMenuItem3.Text = "Consultar";
            // 
            // eliminarToolStripMenuItem3
            // 
            this.eliminarToolStripMenuItem3.Name = "eliminarToolStripMenuItem3";
            this.eliminarToolStripMenuItem3.Size = new System.Drawing.Size(204, 26);
            this.eliminarToolStripMenuItem3.Text = "Eliminar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // puertosToolStripMenuItem
            // 
            this.puertosToolStripMenuItem.Name = "puertosToolStripMenuItem";
            this.puertosToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.puertosToolStripMenuItem.Text = "Gestionar puertos";
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
            this.registrarToolStripMenuItem3.Size = new System.Drawing.Size(147, 26);
            this.registrarToolStripMenuItem3.Text = "Registrar";
            this.registrarToolStripMenuItem3.Click += new System.EventHandler(this.registrarToolStripMenuItem3_Click);
            // 
            // consultarPasajero
            // 
            this.consultarPasajero.Name = "consultarPasajero";
            this.consultarPasajero.Size = new System.Drawing.Size(147, 26);
            this.consultarPasajero.Text = "Consultar";
            this.consultarPasajero.Click += new System.EventHandler(this.consultarPasajero_Click);
            // 
            // reservacionesToolStripMenuItem
            // 
            this.reservacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarReservasToolStripMenuItem});
            this.reservacionesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservacionesToolStripMenuItem.Name = "reservacionesToolStripMenuItem";
            this.reservacionesToolStripMenuItem.Size = new System.Drawing.Size(121, 25);
            this.reservacionesToolStripMenuItem.Text = "Reservaciones";
            // 
            // gestionarReservasToolStripMenuItem
            // 
            this.gestionarReservasToolStripMenuItem.Name = "gestionarReservasToolStripMenuItem";
            this.gestionarReservasToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.gestionarReservasToolStripMenuItem.Text = "Gestionar reservas";
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
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // cambiarUsuarioToolStripMenuItem
            // 
            this.cambiarUsuarioToolStripMenuItem.Name = "cambiarUsuarioToolStripMenuItem";
            this.cambiarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarUsuarioToolStripMenuItem.Text = "Cambiar usuario";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(528, 137);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(181, 41);
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "¡Bienvenido!";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 198);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.menuStrip1);
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
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem barcoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarBarco;
        private System.Windows.Forms.ToolStripMenuItem consultarBarco;
        private System.Windows.Forms.ToolStripSeparator eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camaroteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnConsultarBarco;
        private System.Windows.Forms.ToolStripMenuItem cubiertaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarCubierta;
        private System.Windows.Forms.ToolStripMenuItem viajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarViajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem puertosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarReservasToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem modificarViajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarViajeToolStripMenuItem;
    }
}


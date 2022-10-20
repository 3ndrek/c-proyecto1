namespace Pav_TP.InterfacesDeUsuario.Transacciones
{
    partial class Cobro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbReservas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FechaPagoSeleccionador = new System.Windows.Forms.DateTimePicker();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.CmbModosPagos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnPasajero = new System.Windows.Forms.Button();
            this.CmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.TxtNroDoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PasajeroInfo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NombrePasajero = new System.Windows.Forms.Label();
            this.ApellidoMostrar = new System.Windows.Forms.Label();
            this.ErrorDni = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDni)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbReservas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la reserva que desea abonar:";
            // 
            // CmbReservas
            // 
            this.CmbReservas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbReservas.FormattingEnabled = true;
            this.CmbReservas.Location = new System.Drawing.Point(174, 38);
            this.CmbReservas.Name = "CmbReservas";
            this.CmbReservas.Size = new System.Drawing.Size(136, 28);
            this.CmbReservas.TabIndex = 1;
            this.CmbReservas.SelectionChangeCommitted += new System.EventHandler(this.CmbReservas_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reserva numero";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.FechaPagoSeleccionador);
            this.groupBox2.Controls.Add(this.TxtMonto);
            this.groupBox2.Controls.Add(this.CmbModosPagos);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(10, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingrese los datos del pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de pago";
            // 
            // FechaPagoSeleccionador
            // 
            this.FechaPagoSeleccionador.Location = new System.Drawing.Point(174, 117);
            this.FechaPagoSeleccionador.Name = "FechaPagoSeleccionador";
            this.FechaPagoSeleccionador.Size = new System.Drawing.Size(330, 26);
            this.FechaPagoSeleccionador.TabIndex = 4;
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(174, 74);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(136, 26);
            this.TxtMonto.TabIndex = 3;
            this.TxtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMonto_KeyPress);
            // 
            // CmbModosPagos
            // 
            this.CmbModosPagos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbModosPagos.FormattingEnabled = true;
            this.CmbModosPagos.Location = new System.Drawing.Point(174, 37);
            this.CmbModosPagos.Name = "CmbModosPagos";
            this.CmbModosPagos.Size = new System.Drawing.Size(136, 28);
            this.CmbModosPagos.TabIndex = 2;
            this.CmbModosPagos.SelectionChangeCommitted += new System.EventHandler(this.CmbModosPagos_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Monto a pagar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Modo de pago";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnPasajero);
            this.groupBox3.Controls.Add(this.CmbTipoDoc);
            this.groupBox3.Controls.Add(this.TxtNroDoc);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(10, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(512, 131);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingrese los datos del pasajero";
            // 
            // BtnPasajero
            // 
            this.BtnPasajero.Location = new System.Drawing.Point(392, 88);
            this.BtnPasajero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPasajero.Name = "BtnPasajero";
            this.BtnPasajero.Size = new System.Drawing.Size(112, 35);
            this.BtnPasajero.TabIndex = 8;
            this.BtnPasajero.Text = "Buscar ";
            this.BtnPasajero.UseVisualStyleBackColor = true;
            this.BtnPasajero.Click += new System.EventHandler(this.BtnPasajero_Click);
            // 
            // CmbTipoDoc
            // 
            this.CmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoDoc.FormattingEnabled = true;
            this.CmbTipoDoc.Location = new System.Drawing.Point(200, 29);
            this.CmbTipoDoc.Name = "CmbTipoDoc";
            this.CmbTipoDoc.Size = new System.Drawing.Size(136, 28);
            this.CmbTipoDoc.TabIndex = 6;
            this.CmbTipoDoc.SelectionChangeCommitted += new System.EventHandler(this.CmbTipoDoc_SelectionChangeCommitted);
            // 
            // TxtNroDoc
            // 
            this.TxtNroDoc.Location = new System.Drawing.Point(200, 66);
            this.TxtNroDoc.Name = "TxtNroDoc";
            this.TxtNroDoc.Size = new System.Drawing.Size(136, 26);
            this.TxtNroDoc.TabIndex = 7;
            this.TxtNroDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNroDoc_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Numero de documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo de documento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 565);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Esta seguro que desea abonar esta reserva?";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(278, 605);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 43);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 605);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PasajeroInfo
            // 
            this.PasajeroInfo.AutoSize = true;
            this.PasajeroInfo.Location = new System.Drawing.Point(48, 151);
            this.PasajeroInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasajeroInfo.Name = "PasajeroInfo";
            this.PasajeroInfo.Size = new System.Drawing.Size(73, 20);
            this.PasajeroInfo.TabIndex = 5;
            this.PasajeroInfo.Text = "Nombre: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Apellido:";
            // 
            // NombrePasajero
            // 
            this.NombrePasajero.AutoSize = true;
            this.NombrePasajero.Location = new System.Drawing.Point(184, 151);
            this.NombrePasajero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NombrePasajero.Name = "NombrePasajero";
            this.NombrePasajero.Size = new System.Drawing.Size(42, 20);
            this.NombrePasajero.TabIndex = 7;
            this.NombrePasajero.Text = "label";
            // 
            // ApellidoMostrar
            // 
            this.ApellidoMostrar.AutoSize = true;
            this.ApellidoMostrar.Location = new System.Drawing.Point(184, 198);
            this.ApellidoMostrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ApellidoMostrar.Name = "ApellidoMostrar";
            this.ApellidoMostrar.Size = new System.Drawing.Size(42, 20);
            this.ApellidoMostrar.TabIndex = 8;
            this.ApellidoMostrar.Text = "label";
            // 
            // ErrorDni
            // 
            this.ErrorDni.ContainerControl = this;
            // 
            // Cobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 694);
            this.Controls.Add(this.ApellidoMostrar);
            this.Controls.Add(this.NombrePasajero);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PasajeroInfo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cobro";
            this.Text = "Cobro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cobro_FormClosing);
            this.Load += new System.EventHandler(this.Cobro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorDni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbReservas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker FechaPagoSeleccionador;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.ComboBox CmbModosPagos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CmbTipoDoc;
        private System.Windows.Forms.TextBox TxtNroDoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnPasajero;
        private System.Windows.Forms.Label PasajeroInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label NombrePasajero;
        private System.Windows.Forms.Label ApellidoMostrar;
        private System.Windows.Forms.ErrorProvider ErrorDni;
    }
}
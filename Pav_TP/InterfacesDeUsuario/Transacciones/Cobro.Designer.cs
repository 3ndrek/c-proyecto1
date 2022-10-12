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
            this.CmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.TxtNroDoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbReservas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(317, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la reserva que desea abonar:";
            // 
            // CmbReservas
            // 
            this.CmbReservas.FormattingEnabled = true;
            this.CmbReservas.Location = new System.Drawing.Point(116, 25);
            this.CmbReservas.Margin = new System.Windows.Forms.Padding(2);
            this.CmbReservas.Name = "CmbReservas";
            this.CmbReservas.Size = new System.Drawing.Size(92, 21);
            this.CmbReservas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
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
            this.groupBox2.Location = new System.Drawing.Point(7, 178);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(317, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingrese los datos del pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de pago";
            // 
            // FechaPagoSeleccionador
            // 
            this.FechaPagoSeleccionador.Location = new System.Drawing.Point(116, 76);
            this.FechaPagoSeleccionador.Margin = new System.Windows.Forms.Padding(2);
            this.FechaPagoSeleccionador.Name = "FechaPagoSeleccionador";
            this.FechaPagoSeleccionador.Size = new System.Drawing.Size(189, 20);
            this.FechaPagoSeleccionador.TabIndex = 4;
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(116, 48);
            this.TxtMonto.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(92, 20);
            this.TxtMonto.TabIndex = 3;
            // 
            // CmbModosPagos
            // 
            this.CmbModosPagos.FormattingEnabled = true;
            this.CmbModosPagos.Location = new System.Drawing.Point(116, 24);
            this.CmbModosPagos.Margin = new System.Windows.Forms.Padding(2);
            this.CmbModosPagos.Name = "CmbModosPagos";
            this.CmbModosPagos.Size = new System.Drawing.Size(92, 21);
            this.CmbModosPagos.TabIndex = 2;
            this.CmbModosPagos.SelectionChangeCommitted += new System.EventHandler(this.CmbModosPagos_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Monto a pagar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Modo de pago";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CmbTipoDoc);
            this.groupBox3.Controls.Add(this.TxtNroDoc);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(7, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(317, 81);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingrese los datos del pasajero";
            // 
            // CmbTipoDoc
            // 
            this.CmbTipoDoc.FormattingEnabled = true;
            this.CmbTipoDoc.Location = new System.Drawing.Point(133, 19);
            this.CmbTipoDoc.Margin = new System.Windows.Forms.Padding(2);
            this.CmbTipoDoc.Name = "CmbTipoDoc";
            this.CmbTipoDoc.Size = new System.Drawing.Size(92, 21);
            this.CmbTipoDoc.TabIndex = 6;
            // 
            // TxtNroDoc
            // 
            this.TxtNroDoc.Location = new System.Drawing.Point(133, 43);
            this.TxtNroDoc.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNroDoc.Name = "TxtNroDoc";
            this.TxtNroDoc.Size = new System.Drawing.Size(92, 20);
            this.TxtNroDoc.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Numero de documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo de documento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 306);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Esta seguro que desea abonar esta reserva?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 332);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 332);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Cobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 367);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
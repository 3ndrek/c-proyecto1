namespace PAV1
{
    partial class GenerarViaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarViaje));
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TxtDuracion = new System.Windows.Forms.TextBox();
            this.cmbItininerario = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCod = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBuscar = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.pruebaButton1 = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo de Navio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha de salida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 45);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Itinerario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Duracion de viaje";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(177, 79);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // TxtDuracion
            // 
            this.TxtDuracion.Location = new System.Drawing.Point(177, 76);
            this.TxtDuracion.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDuracion.Name = "TxtDuracion";
            this.TxtDuracion.Size = new System.Drawing.Size(140, 22);
            this.TxtDuracion.TabIndex = 10;
            // 
            // cmbItininerario
            // 
            this.cmbItininerario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItininerario.FormattingEnabled = true;
            this.cmbItininerario.Location = new System.Drawing.Point(177, 36);
            this.cmbItininerario.Margin = new System.Windows.Forms.Padding(2);
            this.cmbItininerario.Name = "cmbItininerario";
            this.cmbItininerario.Size = new System.Drawing.Size(238, 24);
            this.cmbItininerario.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.groupBox1.Location = new System.Drawing.Point(42, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 147);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos del viaje";
            // 
            // cmbCod
            // 
            this.cmbCod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCod.FormattingEnabled = true;
            this.cmbCod.Location = new System.Drawing.Point(177, 42);
            this.cmbCod.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCod.Name = "cmbCod";
            this.cmbCod.Size = new System.Drawing.Size(140, 24);
            this.cmbCod.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbItininerario);
            this.groupBox2.Controls.Add(this.TxtDuracion);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.groupBox2.Location = new System.Drawing.Point(42, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(679, 147);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingrese los datos del itinerario de viaje";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.label13.Location = new System.Drawing.Point(253, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 25);
            this.label13.TabIndex = 74;
            this.label13.Text = "Registrar Viaje";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.btnBuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.btnBuscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscar.BorderRadius = 20;
            this.btnBuscar.BorderSize = 0;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(272, 400);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 38);
            this.btnBuscar.TabIndex = 83;
            this.btnBuscar.Text = "Registrar";
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pruebaButton1
            // 
            this.pruebaButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.pruebaButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.pruebaButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pruebaButton1.BorderRadius = 20;
            this.pruebaButton1.BorderSize = 0;
            this.pruebaButton1.FlatAppearance.BorderSize = 0;
            this.pruebaButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pruebaButton1.ForeColor = System.Drawing.Color.White;
            this.pruebaButton1.Location = new System.Drawing.Point(381, 400);
            this.pruebaButton1.Name = "pruebaButton1";
            this.pruebaButton1.Size = new System.Drawing.Size(87, 38);
            this.pruebaButton1.TabIndex = 85;
            this.pruebaButton1.Text = "Cancelar";
            this.pruebaButton1.TextColor = System.Drawing.Color.White;
            this.pruebaButton1.UseVisualStyleBackColor = false;
            this.pruebaButton1.Click += new System.EventHandler(this.button3_Click);
            // 
            // GenerarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(210)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.pruebaButton1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(109)))), ((int)(((byte)(182)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GenerarViaje";
            this.Text = "Generar viaje";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GenerarViaje_FormClosing);
            this.Load += new System.EventHandler(this.GenerarViaje_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TxtDuracion;
        private System.Windows.Forms.ComboBox cmbItininerario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbCod;
        private Pav_TP.InterfacesDeUsuario.PruebaButton btnBuscar;
        private Pav_TP.InterfacesDeUsuario.PruebaButton pruebaButton1;
    }
}
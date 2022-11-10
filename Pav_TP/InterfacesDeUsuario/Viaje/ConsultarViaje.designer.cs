namespace PAV1
{
    partial class ConsultarViaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarViaje));
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pruebaButton1 = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pruebaButton4 = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.pruebaButton2 = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.btnGuardar = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.DgvViaje = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cod_navio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_viaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_itinerario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvViaje)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Codigo de navio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pruebaButton1);
            this.groupBox1.Controls.Add(this.TxtCodigo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.groupBox1.Location = new System.Drawing.Point(75, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 103);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar viaje por código o fecha";
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
            this.pruebaButton1.Location = new System.Drawing.Point(278, 27);
            this.pruebaButton1.Name = "pruebaButton1";
            this.pruebaButton1.Size = new System.Drawing.Size(87, 38);
            this.pruebaButton1.TabIndex = 77;
            this.pruebaButton1.Text = "Buscar";
            this.pruebaButton1.TextColor = System.Drawing.Color.White;
            this.pruebaButton1.UseVisualStyleBackColor = false;
            this.pruebaButton1.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(153, 35);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 22);
            this.TxtCodigo.TabIndex = 17;
            this.TxtCodigo.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pruebaButton4);
            this.groupBox2.Controls.Add(this.pruebaButton2);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.DgvViaje);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.groupBox2.Location = new System.Drawing.Point(75, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 233);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado de la busqueda";
            // 
            // pruebaButton4
            // 
            this.pruebaButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.pruebaButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.pruebaButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pruebaButton4.BorderRadius = 20;
            this.pruebaButton4.BorderSize = 0;
            this.pruebaButton4.FlatAppearance.BorderSize = 0;
            this.pruebaButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pruebaButton4.ForeColor = System.Drawing.Color.White;
            this.pruebaButton4.Location = new System.Drawing.Point(472, 184);
            this.pruebaButton4.Name = "pruebaButton4";
            this.pruebaButton4.Size = new System.Drawing.Size(87, 38);
            this.pruebaButton4.TabIndex = 83;
            this.pruebaButton4.Text = "Cancelar";
            this.pruebaButton4.TextColor = System.Drawing.Color.White;
            this.pruebaButton4.UseVisualStyleBackColor = false;
            this.pruebaButton4.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pruebaButton2
            // 
            this.pruebaButton2.BackColor = System.Drawing.Color.Red;
            this.pruebaButton2.BackgroundColor = System.Drawing.Color.Red;
            this.pruebaButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pruebaButton2.BorderRadius = 20;
            this.pruebaButton2.BorderSize = 0;
            this.pruebaButton2.FlatAppearance.BorderSize = 0;
            this.pruebaButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pruebaButton2.ForeColor = System.Drawing.Color.White;
            this.pruebaButton2.Location = new System.Drawing.Point(379, 184);
            this.pruebaButton2.Name = "pruebaButton2";
            this.pruebaButton2.Size = new System.Drawing.Size(87, 38);
            this.pruebaButton2.TabIndex = 81;
            this.pruebaButton2.Text = "Eliminar";
            this.pruebaButton2.TextColor = System.Drawing.Color.White;
            this.pruebaButton2.UseVisualStyleBackColor = false;
            this.pruebaButton2.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardar.BorderRadius = 20;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(286, 184);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 38);
            this.btnGuardar.TabIndex = 80;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // DgvViaje
            // 
            this.DgvViaje.AllowUserToAddRows = false;
            this.DgvViaje.AllowUserToDeleteRows = false;
            this.DgvViaje.AllowUserToResizeRows = false;
            this.DgvViaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvViaje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_navio,
            this.fecha_viaje,
            this.duracion,
            this.cod_itinerario});
            this.DgvViaje.Location = new System.Drawing.Point(25, 28);
            this.DgvViaje.MultiSelect = false;
            this.DgvViaje.Name = "DgvViaje";
            this.DgvViaje.ReadOnly = true;
            this.DgvViaje.RowHeadersWidth = 62;
            this.DgvViaje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvViaje.Size = new System.Drawing.Size(534, 150);
            this.DgvViaje.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.label3.Location = new System.Drawing.Point(215, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Consultar Informacion de viajes";
            // 
            // cod_navio
            // 
            this.cod_navio.HeaderText = "cod_navio";
            this.cod_navio.MinimumWidth = 8;
            this.cod_navio.Name = "cod_navio";
            this.cod_navio.ReadOnly = true;
            this.cod_navio.Width = 150;
            // 
            // fecha_viaje
            // 
            this.fecha_viaje.HeaderText = "fecha_viaje";
            this.fecha_viaje.MinimumWidth = 8;
            this.fecha_viaje.Name = "fecha_viaje";
            this.fecha_viaje.ReadOnly = true;
            this.fecha_viaje.Width = 150;
            // 
            // duracion
            // 
            this.duracion.HeaderText = "duracion";
            this.duracion.MinimumWidth = 8;
            this.duracion.Name = "duracion";
            this.duracion.ReadOnly = true;
            this.duracion.Width = 150;
            // 
            // cod_itinerario
            // 
            this.cod_itinerario.HeaderText = "cod_itinerario";
            this.cod_itinerario.MinimumWidth = 8;
            this.cod_itinerario.Name = "cod_itinerario";
            this.cod_itinerario.ReadOnly = true;
            this.cod_itinerario.Width = 150;
            // 
            // ConsultarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(210)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultarViaje";
            this.Text = "Consultar Viaje";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultarViaje_FormClosing);
            this.Load += new System.EventHandler(this.ConsultarViaje_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvViaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvViaje;
        private System.Windows.Forms.TextBox TxtCodigo;
        private Pav_TP.InterfacesDeUsuario.PruebaButton pruebaButton1;
        private Pav_TP.InterfacesDeUsuario.PruebaButton pruebaButton4;
        private Pav_TP.InterfacesDeUsuario.PruebaButton pruebaButton2;
        private Pav_TP.InterfacesDeUsuario.PruebaButton btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_navio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_viaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_itinerario;
    }
}
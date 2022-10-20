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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.DgvViaje = new System.Windows.Forms.DataGridView();
            this.cod_navio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_viaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_itinerario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais_origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais_destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvViaje)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(726, 128);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 35);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Codigo de navio";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(546, 300);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 35);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(375, 300);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 35);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtCodigo);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(60, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(876, 182);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar viaje por código o fecha";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(172, 48);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(148, 26);
            this.TxtCodigo.TabIndex = 17;
            this.TxtCodigo.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.DgvViaje);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Location = new System.Drawing.Point(60, 328);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(876, 358);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado de la busqueda";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(722, 300);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.cod_itinerario,
            this.pais_origen,
            this.pais_destino});
            this.DgvViaje.Location = new System.Drawing.Point(38, 43);
            this.DgvViaje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvViaje.MultiSelect = false;
            this.DgvViaje.Name = "DgvViaje";
            this.DgvViaje.ReadOnly = true;
            this.DgvViaje.RowHeadersWidth = 62;
            this.DgvViaje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvViaje.Size = new System.Drawing.Size(801, 231);
            this.DgvViaje.TabIndex = 31;
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
            // pais_origen
            // 
            this.pais_origen.HeaderText = "pais_origen";
            this.pais_origen.MinimumWidth = 8;
            this.pais_origen.Name = "pais_origen";
            this.pais_origen.ReadOnly = true;
            this.pais_origen.Width = 150;
            // 
            // pais_destino
            // 
            this.pais_destino.HeaderText = "pais_destino";
            this.pais_destino.MinimumWidth = 8;
            this.pais_destino.Name = "pais_destino";
            this.pais_destino.ReadOnly = true;
            this.pais_destino.Width = 150;
            // 
            // ConsultarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 771);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsultarViaje";
            this.Text = "Consultar Viaje";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultarViaje_FormClosing);
            this.Load += new System.EventHandler(this.ConsultarViaje_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvViaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvViaje;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_navio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_viaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_itinerario;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais_origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais_destino;
        private System.Windows.Forms.TextBox TxtCodigo;
    }
}
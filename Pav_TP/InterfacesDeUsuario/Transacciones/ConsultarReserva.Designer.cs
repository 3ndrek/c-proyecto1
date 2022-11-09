
namespace Pav_TP.InterfacesDeUsuario.Transacciones
{
    partial class ConsultarReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarReserva));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvReserva = new System.Windows.Forms.DataGridView();
            this.cod_navio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_cubierta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_camarote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_viaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cama_ocupada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_reservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pruebaButton1 = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.pruebaButton2 = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.pruebaButton3 = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.btnBuscar = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.TxtNumero);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.groupBox1.Location = new System.Drawing.Point(75, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 113);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar viaje por código o fecha";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(179, 35);
            this.TxtNumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(100, 22);
            this.TxtNumero.TabIndex = 17;
            this.TxtNumero.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Número de Reserva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.label3.Location = new System.Drawing.Point(225, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Consultar Información de la reserva";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pruebaButton3);
            this.groupBox2.Controls.Add(this.pruebaButton2);
            this.groupBox2.Controls.Add(this.pruebaButton1);
            this.groupBox2.Controls.Add(this.DgvReserva);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.groupBox2.Location = new System.Drawing.Point(75, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 233);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado de la busqueda";
            // 
            // DgvReserva
            // 
            this.DgvReserva.AllowUserToAddRows = false;
            this.DgvReserva.AllowUserToDeleteRows = false;
            this.DgvReserva.AllowUserToResizeRows = false;
            this.DgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_navio,
            this.num_cubierta,
            this.num_camarote,
            this.fecha_viaje,
            this.cama_ocupada,
            this.tipo_doc,
            this.num_doc,
            this.PrecioReserva,
            this.nro_reservacion});
            this.DgvReserva.Location = new System.Drawing.Point(25, 28);
            this.DgvReserva.MultiSelect = false;
            this.DgvReserva.Name = "DgvReserva";
            this.DgvReserva.ReadOnly = true;
            this.DgvReserva.RowHeadersWidth = 62;
            this.DgvReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvReserva.Size = new System.Drawing.Size(534, 150);
            this.DgvReserva.TabIndex = 31;
            // 
            // cod_navio
            // 
            this.cod_navio.HeaderText = "Código Navio";
            this.cod_navio.MinimumWidth = 8;
            this.cod_navio.Name = "cod_navio";
            this.cod_navio.ReadOnly = true;
            this.cod_navio.Width = 150;
            // 
            // num_cubierta
            // 
            this.num_cubierta.HeaderText = "Número Cubierta";
            this.num_cubierta.MinimumWidth = 8;
            this.num_cubierta.Name = "num_cubierta";
            this.num_cubierta.ReadOnly = true;
            this.num_cubierta.Width = 150;
            // 
            // num_camarote
            // 
            this.num_camarote.HeaderText = "Número Camarote";
            this.num_camarote.MinimumWidth = 8;
            this.num_camarote.Name = "num_camarote";
            this.num_camarote.ReadOnly = true;
            this.num_camarote.Width = 150;
            // 
            // fecha_viaje
            // 
            this.fecha_viaje.HeaderText = "Fecha Viaje";
            this.fecha_viaje.MinimumWidth = 8;
            this.fecha_viaje.Name = "fecha_viaje";
            this.fecha_viaje.ReadOnly = true;
            this.fecha_viaje.Width = 150;
            // 
            // cama_ocupada
            // 
            this.cama_ocupada.HeaderText = "Camas";
            this.cama_ocupada.MinimumWidth = 8;
            this.cama_ocupada.Name = "cama_ocupada";
            this.cama_ocupada.ReadOnly = true;
            this.cama_ocupada.Width = 150;
            // 
            // tipo_doc
            // 
            this.tipo_doc.HeaderText = "Tipo Documento";
            this.tipo_doc.MinimumWidth = 8;
            this.tipo_doc.Name = "tipo_doc";
            this.tipo_doc.ReadOnly = true;
            this.tipo_doc.Width = 150;
            // 
            // num_doc
            // 
            this.num_doc.HeaderText = "Número de Documento";
            this.num_doc.MinimumWidth = 8;
            this.num_doc.Name = "num_doc";
            this.num_doc.ReadOnly = true;
            this.num_doc.Width = 150;
            // 
            // PrecioReserva
            // 
            this.PrecioReserva.HeaderText = "Precio";
            this.PrecioReserva.MinimumWidth = 8;
            this.PrecioReserva.Name = "PrecioReserva";
            this.PrecioReserva.ReadOnly = true;
            this.PrecioReserva.Width = 150;
            // 
            // nro_reservacion
            // 
            this.nro_reservacion.HeaderText = "Número de reserva";
            this.nro_reservacion.MinimumWidth = 8;
            this.nro_reservacion.Name = "nro_reservacion";
            this.nro_reservacion.ReadOnly = true;
            this.nro_reservacion.Width = 150;
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
            this.pruebaButton1.Location = new System.Drawing.Point(472, 184);
            this.pruebaButton1.Name = "pruebaButton1";
            this.pruebaButton1.Size = new System.Drawing.Size(87, 38);
            this.pruebaButton1.TabIndex = 83;
            this.pruebaButton1.Text = "Cancelar";
            this.pruebaButton1.TextColor = System.Drawing.Color.White;
            this.pruebaButton1.UseVisualStyleBackColor = false;
            this.pruebaButton1.Click += new System.EventHandler(this.btnCancel_Click);
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
            // pruebaButton3
            // 
            this.pruebaButton3.BackColor = System.Drawing.Color.ForestGreen;
            this.pruebaButton3.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.pruebaButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pruebaButton3.BorderRadius = 20;
            this.pruebaButton3.BorderSize = 0;
            this.pruebaButton3.FlatAppearance.BorderSize = 0;
            this.pruebaButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pruebaButton3.ForeColor = System.Drawing.Color.White;
            this.pruebaButton3.Location = new System.Drawing.Point(286, 184);
            this.pruebaButton3.Name = "pruebaButton3";
            this.pruebaButton3.Size = new System.Drawing.Size(87, 38);
            this.pruebaButton3.TabIndex = 80;
            this.pruebaButton3.Text = "Agregar";
            this.pruebaButton3.TextColor = System.Drawing.Color.White;
            this.pruebaButton3.UseVisualStyleBackColor = false;
            this.pruebaButton3.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(472, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 38);
            this.btnBuscar.TabIndex = 77;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ConsultarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(210)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarReserva";
            this.Text = "Consultar Reserva";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultarReserva_FormClosing);
            this.Load += new System.EventHandler(this.ConsultarReserva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_navio;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_cubierta;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_camarote;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_viaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn cama_ocupada;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_reservacion;
        private PruebaButton pruebaButton3;
        private PruebaButton pruebaButton2;
        private PruebaButton pruebaButton1;
        private PruebaButton btnBuscar;
    }
}
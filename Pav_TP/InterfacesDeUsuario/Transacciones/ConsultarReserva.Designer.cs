
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtNumero);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(60, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(876, 182);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar viaje por código o fecha";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(214, 54);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(148, 26);
            this.TxtNumero.TabIndex = 17;
            this.TxtNumero.Text = "0";
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
            this.label8.Size = new System.Drawing.Size(150, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Número de Reserva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(478, 33);
            this.label3.TabIndex = 29;
            this.label3.Text = "Consultar Información de la reserva";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.DgvReserva);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Location = new System.Drawing.Point(60, 328);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(876, 358);
            this.groupBox2.TabIndex = 30;
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
            this.DgvReserva.Location = new System.Drawing.Point(38, 43);
            this.DgvReserva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvReserva.MultiSelect = false;
            this.DgvReserva.Name = "DgvReserva";
            this.DgvReserva.ReadOnly = true;
            this.DgvReserva.RowHeadersWidth = 62;
            this.DgvReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvReserva.Size = new System.Drawing.Size(801, 231);
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
            // ConsultarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 771);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView DgvReserva;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_navio;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_cubierta;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_camarote;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_viaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn cama_ocupada;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_reservacion;
    }
}
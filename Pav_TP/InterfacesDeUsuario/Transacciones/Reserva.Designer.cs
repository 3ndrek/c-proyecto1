namespace Pav_TP.InterfacesDeUsuario.Transacciones
{
    partial class Reserva
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
            this.DgvViajes = new System.Windows.Forms.DataGridView();
            this.cod_navio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAV_3K2_2022_12DataSet3 = new Pav_TP.PAV_3K2_2022_12DataSet3();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtCant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvCamarotes = new System.Windows.Forms.DataGridView();
            this.codigo_navio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_camarote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cubierta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_camarote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant_camas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_cubierta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camarotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAV_3K2_2022_12DataSet4 = new Pav_TP.PAV_3K2_2022_12DataSet4();
            this.camarotesTableAdapter = new Pav_TP.PAV_3K2_2022_12DataSet4TableAdapters.camarotesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CmbItinerario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvPuertos = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viajeTableAdapter = new Pav_TP.PAV_3K2_2022_12DataSet3TableAdapters.viajeTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNroDoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnBuscarPasajero = new System.Windows.Forms.Button();
            this.nombrePasajero = new System.Windows.Forms.Label();
            this.apellidoPasajero = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvViajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viajeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV_3K2_2022_12DataSet3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCamarotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camarotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV_3K2_2022_12DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPuertos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvViajes);
            this.groupBox1.Location = new System.Drawing.Point(305, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(708, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el viaje que desea reservar";
            // 
            // DgvViajes
            // 
            this.DgvViajes.AllowUserToAddRows = false;
            this.DgvViajes.AllowUserToDeleteRows = false;
            this.DgvViajes.AllowUserToResizeRows = false;
            this.DgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvViajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_navio,
            this.fecha_salida,
            this.duracion});
            this.DgvViajes.Location = new System.Drawing.Point(12, 27);
            this.DgvViajes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvViajes.MultiSelect = false;
            this.DgvViajes.Name = "DgvViajes";
            this.DgvViajes.ReadOnly = true;
            this.DgvViajes.RowHeadersWidth = 51;
            this.DgvViajes.RowTemplate.Height = 24;
            this.DgvViajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvViajes.Size = new System.Drawing.Size(679, 122);
            this.DgvViajes.TabIndex = 0;
            // 
            // cod_navio
            // 
            this.cod_navio.HeaderText = "Codigo Navio";
            this.cod_navio.MinimumWidth = 8;
            this.cod_navio.Name = "cod_navio";
            this.cod_navio.ReadOnly = true;
            this.cod_navio.Visible = false;
            this.cod_navio.Width = 150;
            // 
            // fecha_salida
            // 
            this.fecha_salida.HeaderText = "Fecha Salida";
            this.fecha_salida.MinimumWidth = 8;
            this.fecha_salida.Name = "fecha_salida";
            this.fecha_salida.ReadOnly = true;
            this.fecha_salida.Width = 150;
            // 
            // duracion
            // 
            this.duracion.HeaderText = "Duracion";
            this.duracion.MinimumWidth = 8;
            this.duracion.Name = "duracion";
            this.duracion.ReadOnly = true;
            this.duracion.Width = 150;
            // 
            // viajeBindingSource
            // 
            this.viajeBindingSource.DataMember = "viaje";
            this.viajeBindingSource.DataSource = this.pAV_3K2_2022_12DataSet3;
            // 
            // pAV_3K2_2022_12DataSet3
            // 
            this.pAV_3K2_2022_12DataSet3.DataSetName = "PAV_3K2_2022_12DataSet3";
            this.pAV_3K2_2022_12DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnBuscar);
            this.groupBox2.Controls.Add(this.TxtCant);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.DgvCamarotes);
            this.groupBox2.Location = new System.Drawing.Point(305, 195);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(708, 275);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione un camarote";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(463, 18);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtCant
            // 
            this.TxtCant.Location = new System.Drawing.Point(312, 20);
            this.TxtCant.Name = "TxtCant";
            this.TxtCant.Size = new System.Drawing.Size(104, 20);
            this.TxtCant.TabIndex = 2;
            this.TxtCant.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cant. De Pasajeros";
            // 
            // DgvCamarotes
            // 
            this.DgvCamarotes.AllowUserToAddRows = false;
            this.DgvCamarotes.AllowUserToDeleteRows = false;
            this.DgvCamarotes.AllowUserToResizeRows = false;
            this.DgvCamarotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCamarotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_navio,
            this.num_camarote,
            this.cubierta,
            this.tipo_camarote,
            this.cant_camas,
            this.num_cubierta,
            this.monto});
            this.DgvCamarotes.Location = new System.Drawing.Point(12, 54);
            this.DgvCamarotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvCamarotes.MultiSelect = false;
            this.DgvCamarotes.Name = "DgvCamarotes";
            this.DgvCamarotes.ReadOnly = true;
            this.DgvCamarotes.RowHeadersWidth = 51;
            this.DgvCamarotes.RowTemplate.Height = 24;
            this.DgvCamarotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCamarotes.Size = new System.Drawing.Size(679, 204);
            this.DgvCamarotes.TabIndex = 0;
            // 
            // codigo_navio
            // 
            this.codigo_navio.HeaderText = "navio";
            this.codigo_navio.MinimumWidth = 8;
            this.codigo_navio.Name = "codigo_navio";
            this.codigo_navio.ReadOnly = true;
            this.codigo_navio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.codigo_navio.Visible = false;
            this.codigo_navio.Width = 150;
            // 
            // num_camarote
            // 
            this.num_camarote.HeaderText = "Número de camarote";
            this.num_camarote.MinimumWidth = 8;
            this.num_camarote.Name = "num_camarote";
            this.num_camarote.ReadOnly = true;
            this.num_camarote.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.num_camarote.Width = 150;
            // 
            // cubierta
            // 
            this.cubierta.HeaderText = "cubierta";
            this.cubierta.MinimumWidth = 8;
            this.cubierta.Name = "cubierta";
            this.cubierta.ReadOnly = true;
            this.cubierta.Width = 250;
            // 
            // tipo_camarote
            // 
            this.tipo_camarote.HeaderText = "Tipo Camarote";
            this.tipo_camarote.MinimumWidth = 8;
            this.tipo_camarote.Name = "tipo_camarote";
            this.tipo_camarote.ReadOnly = true;
            this.tipo_camarote.Width = 150;
            // 
            // cant_camas
            // 
            this.cant_camas.HeaderText = "cantidad de camas";
            this.cant_camas.MinimumWidth = 8;
            this.cant_camas.Name = "cant_camas";
            this.cant_camas.ReadOnly = true;
            this.cant_camas.Width = 150;
            // 
            // num_cubierta
            // 
            this.num_cubierta.HeaderText = "num_cubierta";
            this.num_cubierta.MinimumWidth = 8;
            this.num_cubierta.Name = "num_cubierta";
            this.num_cubierta.ReadOnly = true;
            this.num_cubierta.Visible = false;
            this.num_cubierta.Width = 150;
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto";
            this.monto.MinimumWidth = 8;
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.Width = 150;
            // 
            // camarotesBindingSource
            // 
            this.camarotesBindingSource.DataMember = "camarotes";
            this.camarotesBindingSource.DataSource = this.pAV_3K2_2022_12DataSet4;
            // 
            // pAV_3K2_2022_12DataSet4
            // 
            this.pAV_3K2_2022_12DataSet4.DataSetName = "PAV_3K2_2022_12DataSet4";
            this.pAV_3K2_2022_12DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // camarotesTableAdapter
            // 
            this.camarotesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(748, 472);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Esta seguro de que desea reservar este camarote?";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(751, 499);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(85, 30);
            this.BtnAceptar.TabIndex = 3;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(923, 499);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CmbItinerario
            // 
            this.CmbItinerario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbItinerario.FormattingEnabled = true;
            this.CmbItinerario.Location = new System.Drawing.Point(29, 194);
            this.CmbItinerario.Name = "CmbItinerario";
            this.CmbItinerario.Size = new System.Drawing.Size(238, 21);
            this.CmbItinerario.TabIndex = 5;
            this.CmbItinerario.SelectionChangeCommitted += new System.EventHandler(this.CmbItinerario_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccione el itinerario a reservar";
            // 
            // DgvPuertos
            // 
            this.DgvPuertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPuertos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre});
            this.DgvPuertos.Location = new System.Drawing.Point(29, 230);
            this.DgvPuertos.Name = "DgvPuertos";
            this.DgvPuertos.RowHeadersWidth = 62;
            this.DgvPuertos.Size = new System.Drawing.Size(238, 316);
            this.DgvPuertos.TabIndex = 7;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 8;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // viajeTableAdapter
            // 
            this.viajeTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo Documento";
            // 
            // CmbTipoDoc
            // 
            this.CmbTipoDoc.FormattingEnabled = true;
            this.CmbTipoDoc.Location = new System.Drawing.Point(150, 47);
            this.CmbTipoDoc.Name = "CmbTipoDoc";
            this.CmbTipoDoc.Size = new System.Drawing.Size(104, 21);
            this.CmbTipoDoc.TabIndex = 12;
            this.CmbTipoDoc.SelectionChangeCommitted += new System.EventHandler(this.CmbTipoDoc_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ingrese los datos del pasajero a reservar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Número de documento";
            // 
            // TxtNroDoc
            // 
            this.TxtNroDoc.Location = new System.Drawing.Point(150, 82);
            this.TxtNroDoc.Name = "TxtNroDoc";
            this.TxtNroDoc.Size = new System.Drawing.Size(104, 20);
            this.TxtNroDoc.TabIndex = 15;
            this.TxtNroDoc.Text = "0";
            this.TxtNroDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNroDoc_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nombre: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Apellido: ";
            // 
            // BtnBuscarPasajero
            // 
            this.BtnBuscarPasajero.Location = new System.Drawing.Point(192, 134);
            this.BtnBuscarPasajero.Name = "BtnBuscarPasajero";
            this.BtnBuscarPasajero.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarPasajero.TabIndex = 18;
            this.BtnBuscarPasajero.Text = "Buscar";
            this.BtnBuscarPasajero.UseVisualStyleBackColor = true;
            this.BtnBuscarPasajero.Click += new System.EventHandler(this.BtnBuscarPasajero_Click);
            // 
            // nombrePasajero
            // 
            this.nombrePasajero.AutoSize = true;
            this.nombrePasajero.Location = new System.Drawing.Point(94, 111);
            this.nombrePasajero.Name = "nombrePasajero";
            this.nombrePasajero.Size = new System.Drawing.Size(0, 13);
            this.nombrePasajero.TabIndex = 19;
            // 
            // apellidoPasajero
            // 
            this.apellidoPasajero.AutoSize = true;
            this.apellidoPasajero.Location = new System.Drawing.Point(94, 139);
            this.apellidoPasajero.Name = "apellidoPasajero";
            this.apellidoPasajero.Size = new System.Drawing.Size(0, 13);
            this.apellidoPasajero.TabIndex = 20;
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 571);
            this.Controls.Add(this.apellidoPasajero);
            this.Controls.Add(this.nombrePasajero);
            this.Controls.Add(this.BtnBuscarPasajero);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtNroDoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbTipoDoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DgvPuertos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbItinerario);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Reserva";
            this.Text = "Reserva";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reserva_FormClosing);
            this.Load += new System.EventHandler(this.Reserva_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvViajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viajeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV_3K2_2022_12DataSet3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCamarotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camarotesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV_3K2_2022_12DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPuertos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvViajes;
        private PAV_3K2_2022_12DataSet3 pAV_3K2_2022_12DataSet3;
        private System.Windows.Forms.BindingSource viajeBindingSource;
        private PAV_3K2_2022_12DataSet3TableAdapters.viajeTableAdapter viajeTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvCamarotes;
        private PAV_3K2_2022_12DataSet4 pAV_3K2_2022_12DataSet4;
        private System.Windows.Forms.BindingSource camarotesBindingSource;
        private PAV_3K2_2022_12DataSet4TableAdapters.camarotesTableAdapter camarotesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CmbItinerario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvPuertos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_navio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbTipoDoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNroDoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnBuscarPasajero;
        private System.Windows.Forms.Label nombrePasajero;
        private System.Windows.Forms.Label apellidoPasajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_navio;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_camarote;
        private System.Windows.Forms.DataGridViewTextBoxColumn cubierta;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_camarote;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant_camas;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_cubierta;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
    }
}
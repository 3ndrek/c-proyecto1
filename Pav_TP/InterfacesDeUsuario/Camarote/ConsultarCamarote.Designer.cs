namespace Pav_TP.InterfacesDeUsuario.Camarote
{
    partial class ConsultarCamarote
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbNavio = new System.Windows.Forms.ComboBox();
            this.CmbCubierta = new System.Windows.Forms.ComboBox();
            this.TxtNro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.GrillaCamarotes = new System.Windows.Forms.DataGridView();
            this.camarotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAV_3K2_2022_12DataSet5 = new Pav_TP.PAV_3K2_2022_12DataSet5();
            this.camarotesTableAdapter = new Pav_TP.PAV_3K2_2022_12DataSet5TableAdapters.camarotesTableAdapter();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.codnavioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcubiertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcamaroteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantcamasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaCamarotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camarotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV_3K2_2022_12DataSet5)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Navio*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cubierta*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero de Camarote";
            // 
            // CmbNavio
            // 
            this.CmbNavio.FormattingEnabled = true;
            this.CmbNavio.Location = new System.Drawing.Point(60, 39);
            this.CmbNavio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbNavio.Name = "CmbNavio";
            this.CmbNavio.Size = new System.Drawing.Size(92, 21);
            this.CmbNavio.TabIndex = 4;
            // 
            // CmbCubierta
            // 
            this.CmbCubierta.FormattingEnabled = true;
            this.CmbCubierta.Location = new System.Drawing.Point(61, 68);
            this.CmbCubierta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbCubierta.Name = "CmbCubierta";
            this.CmbCubierta.Size = new System.Drawing.Size(92, 21);
            this.CmbCubierta.TabIndex = 5;
            this.CmbCubierta.Click += new System.EventHandler(this.CmbCubierta_Click);
            // 
            // TxtNro
            // 
            this.TxtNro.Location = new System.Drawing.Point(119, 98);
            this.TxtNro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNro.Name = "TxtNro";
            this.TxtNro.Size = new System.Drawing.Size(76, 20);
            this.TxtNro.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.CmbNavio);
            this.groupBox1.Controls.Add(this.TxtNro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CmbCubierta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(322, 155);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos del camarote que desea consultar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Obligatorios: *";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(248, 124);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(56, 19);
            this.BtnBuscar.TabIndex = 7;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // GrillaCamarotes
            // 
            this.GrillaCamarotes.AutoGenerateColumns = false;
            this.GrillaCamarotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaCamarotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codnavioDataGridViewTextBoxColumn,
            this.numcubiertaDataGridViewTextBoxColumn,
            this.numcamaroteDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.cantcamasDataGridViewTextBoxColumn,
            this.Seleccionar});
            this.GrillaCamarotes.DataSource = this.camarotesBindingSource;
            this.GrillaCamarotes.Location = new System.Drawing.Point(9, 218);
            this.GrillaCamarotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrillaCamarotes.Name = "GrillaCamarotes";
            this.GrillaCamarotes.RowHeadersWidth = 51;
            this.GrillaCamarotes.RowTemplate.Height = 24;
            this.GrillaCamarotes.Size = new System.Drawing.Size(922, 193);
            this.GrillaCamarotes.TabIndex = 8;
            // 
            // camarotesBindingSource
            // 
            this.camarotesBindingSource.DataMember = "camarotes";
            this.camarotesBindingSource.DataSource = this.pAV_3K2_2022_12DataSet5;
            // 
            // pAV_3K2_2022_12DataSet5
            // 
            this.pAV_3K2_2022_12DataSet5.DataSetName = "PAV_3K2_2022_12DataSet5";
            this.pAV_3K2_2022_12DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // camarotesTableAdapter
            // 
            this.camarotesTableAdapter.ClearBeforeFill = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(74, 24);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(56, 26);
            this.BtnAgregar.TabIndex = 9;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(250, 32);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(56, 26);
            this.BtnEliminar.TabIndex = 10;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnAgregar);
            this.groupBox2.Location = new System.Drawing.Point(394, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(211, 60);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desea registrar un nuevo camarote?";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.BtnEliminar);
            this.groupBox3.Location = new System.Drawing.Point(394, 94);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(332, 71);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Desea eliminar algun camarote?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Seleccione uno o mas camarotes para eliminarlos";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(895, 440);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(56, 19);
            this.BtnSalir.TabIndex = 13;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // codnavioDataGridViewTextBoxColumn
            // 
            this.codnavioDataGridViewTextBoxColumn.DataPropertyName = "cod_navio";
            this.codnavioDataGridViewTextBoxColumn.HeaderText = "cod_navio";
            this.codnavioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codnavioDataGridViewTextBoxColumn.Name = "codnavioDataGridViewTextBoxColumn";
            this.codnavioDataGridViewTextBoxColumn.Width = 125;
            // 
            // numcubiertaDataGridViewTextBoxColumn
            // 
            this.numcubiertaDataGridViewTextBoxColumn.DataPropertyName = "num_cubierta";
            this.numcubiertaDataGridViewTextBoxColumn.HeaderText = "num_cubierta";
            this.numcubiertaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numcubiertaDataGridViewTextBoxColumn.Name = "numcubiertaDataGridViewTextBoxColumn";
            this.numcubiertaDataGridViewTextBoxColumn.Width = 125;
            // 
            // numcamaroteDataGridViewTextBoxColumn
            // 
            this.numcamaroteDataGridViewTextBoxColumn.DataPropertyName = "num_camarote";
            this.numcamaroteDataGridViewTextBoxColumn.HeaderText = "Nro de Camarote";
            this.numcamaroteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numcamaroteDataGridViewTextBoxColumn.Name = "numcamaroteDataGridViewTextBoxColumn";
            this.numcamaroteDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo de Camarote";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantcamasDataGridViewTextBoxColumn
            // 
            this.cantcamasDataGridViewTextBoxColumn.DataPropertyName = "cant_camas";
            this.cantcamasDataGridViewTextBoxColumn.HeaderText = "Cantidad de Camas";
            this.cantcamasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantcamasDataGridViewTextBoxColumn.Name = "cantcamasDataGridViewTextBoxColumn";
            this.cantcamasDataGridViewTextBoxColumn.Width = 125;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Width = 125;
            // 
            // ConsultarCamarote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 475);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GrillaCamarotes);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultarCamarote";
            this.Text = "ConsultarCamarote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultarCamarote_FormClosing);
            this.Load += new System.EventHandler(this.ConsultarCamarote_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaCamarotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camarotesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV_3K2_2022_12DataSet5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbNavio;
        private System.Windows.Forms.ComboBox CmbCubierta;
        private System.Windows.Forms.TextBox TxtNro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView GrillaCamarotes;
        private System.Windows.Forms.Label label1;
        private PAV_3K2_2022_12DataSet5 pAV_3K2_2022_12DataSet5;
        private System.Windows.Forms.BindingSource camarotesBindingSource;
        private PAV_3K2_2022_12DataSet5TableAdapters.camarotesTableAdapter camarotesTableAdapter;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn codnavioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcubiertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcamaroteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantcamasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
    }
}
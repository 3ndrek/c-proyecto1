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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAV_3K2_2022_12DataSet3 = new Pav_TP.PAV_3K2_2022_12DataSet3();
            this.viajeTableAdapter = new Pav_TP.PAV_3K2_2022_12DataSet3TableAdapters.viajeTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.camarotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAV_3K2_2022_12DataSet4 = new Pav_TP.PAV_3K2_2022_12DataSet4();
            this.camarotesTableAdapter = new Pav_TP.PAV_3K2_2022_12DataSet4TableAdapters.camarotesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.codnavioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaviajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coditinerarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisorigenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisdestinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.codnavioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcubiertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcamaroteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantcamasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadCamasD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reservar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viajeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV_3K2_2022_12DataSet3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camarotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV_3K2_2022_12DataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el viaje que desea reservar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codnavioDataGridViewTextBoxColumn,
            this.fechaviajeDataGridViewTextBoxColumn,
            this.duracionDataGridViewTextBoxColumn,
            this.coditinerarioDataGridViewTextBoxColumn,
            this.paisorigenDataGridViewTextBoxColumn,
            this.paisdestinoDataGridViewTextBoxColumn,
            this.Seleccionar});
            this.dataGridView1.DataSource = this.viajeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(681, 159);
            this.dataGridView1.TabIndex = 0;
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
            // viajeTableAdapter
            // 
            this.viajeTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(13, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione un camarote";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codnavioDataGridViewTextBoxColumn1,
            this.numcubiertaDataGridViewTextBoxColumn,
            this.numcamaroteDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.ubicacionDataGridViewTextBoxColumn,
            this.cantcamasDataGridViewTextBoxColumn,
            this.cantidadCamasD,
            this.Reservar});
            this.dataGridView2.DataSource = this.camarotesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(16, 33);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(681, 159);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Esta seguro de que desea reservar este camarote?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(648, 568);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // codnavioDataGridViewTextBoxColumn
            // 
            this.codnavioDataGridViewTextBoxColumn.DataPropertyName = "cod_navio";
            this.codnavioDataGridViewTextBoxColumn.HeaderText = "cod_navio";
            this.codnavioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codnavioDataGridViewTextBoxColumn.Name = "codnavioDataGridViewTextBoxColumn";
            this.codnavioDataGridViewTextBoxColumn.Visible = false;
            this.codnavioDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaviajeDataGridViewTextBoxColumn
            // 
            this.fechaviajeDataGridViewTextBoxColumn.DataPropertyName = "fecha_viaje";
            this.fechaviajeDataGridViewTextBoxColumn.HeaderText = "fecha_viaje";
            this.fechaviajeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaviajeDataGridViewTextBoxColumn.Name = "fechaviajeDataGridViewTextBoxColumn";
            this.fechaviajeDataGridViewTextBoxColumn.Width = 125;
            // 
            // duracionDataGridViewTextBoxColumn
            // 
            this.duracionDataGridViewTextBoxColumn.DataPropertyName = "duracion";
            this.duracionDataGridViewTextBoxColumn.HeaderText = "duracion";
            this.duracionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.duracionDataGridViewTextBoxColumn.Name = "duracionDataGridViewTextBoxColumn";
            this.duracionDataGridViewTextBoxColumn.Width = 125;
            // 
            // coditinerarioDataGridViewTextBoxColumn
            // 
            this.coditinerarioDataGridViewTextBoxColumn.DataPropertyName = "cod_itinerario";
            this.coditinerarioDataGridViewTextBoxColumn.HeaderText = "cod_itinerario";
            this.coditinerarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coditinerarioDataGridViewTextBoxColumn.Name = "coditinerarioDataGridViewTextBoxColumn";
            this.coditinerarioDataGridViewTextBoxColumn.Visible = false;
            this.coditinerarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // paisorigenDataGridViewTextBoxColumn
            // 
            this.paisorigenDataGridViewTextBoxColumn.DataPropertyName = "pais_origen";
            this.paisorigenDataGridViewTextBoxColumn.HeaderText = "pais_origen";
            this.paisorigenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paisorigenDataGridViewTextBoxColumn.Name = "paisorigenDataGridViewTextBoxColumn";
            this.paisorigenDataGridViewTextBoxColumn.Width = 125;
            // 
            // paisdestinoDataGridViewTextBoxColumn
            // 
            this.paisdestinoDataGridViewTextBoxColumn.DataPropertyName = "pais_destino";
            this.paisdestinoDataGridViewTextBoxColumn.HeaderText = "pais_destino";
            this.paisdestinoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paisdestinoDataGridViewTextBoxColumn.Name = "paisdestinoDataGridViewTextBoxColumn";
            this.paisdestinoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuantas camas desea reservar?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de camas:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 228);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            this.comboBox1.TabIndex = 3;
            // 
            // codnavioDataGridViewTextBoxColumn1
            // 
            this.codnavioDataGridViewTextBoxColumn1.DataPropertyName = "cod_navio";
            this.codnavioDataGridViewTextBoxColumn1.HeaderText = "cod_navio";
            this.codnavioDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.codnavioDataGridViewTextBoxColumn1.Name = "codnavioDataGridViewTextBoxColumn1";
            this.codnavioDataGridViewTextBoxColumn1.Visible = false;
            this.codnavioDataGridViewTextBoxColumn1.Width = 125;
            // 
            // numcubiertaDataGridViewTextBoxColumn
            // 
            this.numcubiertaDataGridViewTextBoxColumn.DataPropertyName = "num_cubierta";
            this.numcubiertaDataGridViewTextBoxColumn.HeaderText = "num_cubierta";
            this.numcubiertaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numcubiertaDataGridViewTextBoxColumn.Name = "numcubiertaDataGridViewTextBoxColumn";
            this.numcubiertaDataGridViewTextBoxColumn.Visible = false;
            this.numcubiertaDataGridViewTextBoxColumn.Width = 125;
            // 
            // numcamaroteDataGridViewTextBoxColumn
            // 
            this.numcamaroteDataGridViewTextBoxColumn.DataPropertyName = "num_camarote";
            this.numcamaroteDataGridViewTextBoxColumn.HeaderText = "num_camarote";
            this.numcamaroteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numcamaroteDataGridViewTextBoxColumn.Name = "numcamaroteDataGridViewTextBoxColumn";
            this.numcamaroteDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ubicacionDataGridViewTextBoxColumn
            // 
            this.ubicacionDataGridViewTextBoxColumn.DataPropertyName = "ubicacion";
            this.ubicacionDataGridViewTextBoxColumn.HeaderText = "ubicacion";
            this.ubicacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ubicacionDataGridViewTextBoxColumn.Name = "ubicacionDataGridViewTextBoxColumn";
            this.ubicacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantcamasDataGridViewTextBoxColumn
            // 
            this.cantcamasDataGridViewTextBoxColumn.DataPropertyName = "cant_camas";
            this.cantcamasDataGridViewTextBoxColumn.HeaderText = "cant_camas";
            this.cantcamasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantcamasDataGridViewTextBoxColumn.Name = "cantcamasDataGridViewTextBoxColumn";
            this.cantcamasDataGridViewTextBoxColumn.Visible = false;
            this.cantcamasDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadCamasD
            // 
            this.cantidadCamasD.HeaderText = "camas_disponibles";
            this.cantidadCamasD.MinimumWidth = 6;
            this.cantidadCamasD.Name = "cantidadCamasD";
            this.cantidadCamasD.Width = 125;
            // 
            // Reservar
            // 
            this.Reservar.HeaderText = "reservar";
            this.Reservar.MinimumWidth = 6;
            this.Reservar.Name = "Reservar";
            this.Reservar.Width = 125;
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 612);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Reserva";
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.Reserva_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viajeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV_3K2_2022_12DataSet3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camarotesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAV_3K2_2022_12DataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PAV_3K2_2022_12DataSet3 pAV_3K2_2022_12DataSet3;
        private System.Windows.Forms.BindingSource viajeBindingSource;
        private PAV_3K2_2022_12DataSet3TableAdapters.viajeTableAdapter viajeTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private PAV_3K2_2022_12DataSet4 pAV_3K2_2022_12DataSet4;
        private System.Windows.Forms.BindingSource camarotesBindingSource;
        private PAV_3K2_2022_12DataSet4TableAdapters.camarotesTableAdapter camarotesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codnavioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaviajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coditinerarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisorigenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisdestinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codnavioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcubiertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcamaroteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantcamasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadCamasD;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Reservar;
    }
}
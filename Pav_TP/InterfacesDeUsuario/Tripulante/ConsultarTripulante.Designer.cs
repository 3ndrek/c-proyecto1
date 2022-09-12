
namespace TrabajoPracticoPav
{
    partial class ConsultarTripulante
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEmial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.genero = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.genero);
            this.groupBox1.Controls.Add(this.dni);
            this.groupBox1.Controls.Add(this.apellido);
            this.groupBox1.Location = new System.Drawing.Point(40, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 361);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Tripulante";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar,
            this.Nombre,
            this.Apellidos,
            this.gridGenero,
            this.gridEmial,
            this.gridFecha,
            this.gridTipo,
            this.gridDni,
            this.gridCiudad,
            this.gridPais});
            this.dataGridView1.Location = new System.Drawing.Point(44, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 150);
            this.dataGridView1.TabIndex = 30;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellido";
            this.Apellidos.Name = "Apellidos";
            // 
            // gridGenero
            // 
            this.gridGenero.HeaderText = "Genero";
            this.gridGenero.Name = "gridGenero";
            // 
            // gridEmial
            // 
            this.gridEmial.HeaderText = "Email";
            this.gridEmial.Name = "gridEmial";
            // 
            // gridFecha
            // 
            this.gridFecha.HeaderText = "Fecha";
            this.gridFecha.Name = "gridFecha";
            // 
            // gridTipo
            // 
            this.gridTipo.HeaderText = "Tipo DNI";
            this.gridTipo.Name = "gridTipo";
            // 
            // gridDni
            // 
            this.gridDni.HeaderText = "DNI";
            this.gridDni.Name = "gridDni";
            // 
            // gridCiudad
            // 
            this.gridCiudad.HeaderText = "Ciudad Origen";
            this.gridCiudad.Name = "gridCiudad";
            // 
            // gridPais
            // 
            this.gridPais.HeaderText = "País";
            this.gridPais.Name = "gridPais";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(322, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Location = new System.Drawing.Point(322, 81);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(322, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(322, 52);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(89, 96);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 23;
            // 
            // genero
            // 
            this.genero.AutoSize = true;
            this.genero.Location = new System.Drawing.Point(21, 99);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(39, 13);
            this.genero.TabIndex = 22;
            this.genero.Text = "Legajo";
            this.genero.Click += new System.EventHandler(this.genero_Click);
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Location = new System.Drawing.Point(19, 62);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(26, 13);
            this.dni.TabIndex = 20;
            this.dni.Text = "DNI";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Location = new System.Drawing.Point(19, 27);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(44, 13);
            this.apellido.TabIndex = 21;
            this.apellido.Text = "Apellido";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 31;
            // 
            // ConsultarTripulante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsultarTripulante";
            this.Text = "ConsultarTripulante";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridEmial;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPais;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label genero;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
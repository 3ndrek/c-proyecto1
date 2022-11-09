namespace Pav_TP.InterfacesDeUsuario.Puerto
{
    partial class ConsultarPuerto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarPuerto));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvPuerto = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtFiltroNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFiltroCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.btnCancel = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.pruebaButton1 = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.pruebaButton2 = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.pruebaButton3 = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPuerto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.pruebaButton1);
            this.groupBox2.Controls.Add(this.pruebaButton2);
            this.groupBox2.Controls.Add(this.pruebaButton3);
            this.groupBox2.Controls.Add(this.DgvPuerto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.groupBox2.Location = new System.Drawing.Point(75, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 233);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados de la busqueda";
            // 
            // DgvPuerto
            // 
            this.DgvPuerto.AllowUserToAddRows = false;
            this.DgvPuerto.AllowUserToDeleteRows = false;
            this.DgvPuerto.AllowUserToResizeRows = false;
            this.DgvPuerto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPuerto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Seleccionar});
            this.DgvPuerto.Location = new System.Drawing.Point(25, 28);
            this.DgvPuerto.MultiSelect = false;
            this.DgvPuerto.Name = "DgvPuerto";
            this.DgvPuerto.ReadOnly = true;
            this.DgvPuerto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPuerto.Size = new System.Drawing.Size(534, 150);
            this.DgvPuerto.TabIndex = 26;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.TxtFiltroNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtFiltroCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.groupBox1.Location = new System.Drawing.Point(75, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 103);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por código o nombre";
            // 
            // TxtFiltroNombre
            // 
            this.TxtFiltroNombre.Location = new System.Drawing.Point(361, 32);
            this.TxtFiltroNombre.Name = "TxtFiltroNombre";
            this.TxtFiltroNombre.Size = new System.Drawing.Size(100, 22);
            this.TxtFiltroNombre.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código";
            // 
            // TxtFiltroCodigo
            // 
            this.TxtFiltroCodigo.Location = new System.Drawing.Point(115, 31);
            this.TxtFiltroCodigo.Name = "TxtFiltroCodigo";
            this.TxtFiltroCodigo.Size = new System.Drawing.Size(100, 22);
            this.TxtFiltroCodigo.TabIndex = 12;
            this.TxtFiltroCodigo.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.label3.Location = new System.Drawing.Point(215, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Consultar Informacion de Puerto";
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
            this.btnBuscar.Location = new System.Drawing.Point(472, 57);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 38);
            this.btnBuscar.TabIndex = 77;
            this.btnBuscar.Text = "Filtrar";
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnFiltro_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(472, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 38);
            this.btnCancel.TabIndex = 83;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pruebaButton1
            // 
            this.pruebaButton1.BackColor = System.Drawing.Color.DarkOrange;
            this.pruebaButton1.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.pruebaButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pruebaButton1.BorderRadius = 20;
            this.pruebaButton1.BorderSize = 0;
            this.pruebaButton1.FlatAppearance.BorderSize = 0;
            this.pruebaButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pruebaButton1.ForeColor = System.Drawing.Color.White;
            this.pruebaButton1.Location = new System.Drawing.Point(379, 184);
            this.pruebaButton1.Name = "pruebaButton1";
            this.pruebaButton1.Size = new System.Drawing.Size(87, 38);
            this.pruebaButton1.TabIndex = 82;
            this.pruebaButton1.Text = "Modificar";
            this.pruebaButton1.TextColor = System.Drawing.Color.White;
            this.pruebaButton1.UseVisualStyleBackColor = false;
            this.pruebaButton1.Click += new System.EventHandler(this.BtnModificar_Click);
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
            this.pruebaButton2.Location = new System.Drawing.Point(286, 184);
            this.pruebaButton2.Name = "pruebaButton2";
            this.pruebaButton2.Size = new System.Drawing.Size(87, 38);
            this.pruebaButton2.TabIndex = 81;
            this.pruebaButton2.Text = "Eliminar";
            this.pruebaButton2.TextColor = System.Drawing.Color.White;
            this.pruebaButton2.UseVisualStyleBackColor = false;
            this.pruebaButton2.Click += new System.EventHandler(this.BtnEliminar_Click);
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
            this.pruebaButton3.Location = new System.Drawing.Point(193, 184);
            this.pruebaButton3.Name = "pruebaButton3";
            this.pruebaButton3.Size = new System.Drawing.Size(87, 38);
            this.pruebaButton3.TabIndex = 80;
            this.pruebaButton3.Text = "Agregar";
            this.pruebaButton3.TextColor = System.Drawing.Color.White;
            this.pruebaButton3.UseVisualStyleBackColor = false;
            this.pruebaButton3.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // ConsultarPuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(210)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarPuerto";
            this.Text = "ConsultarPuerto";
            this.Load += new System.EventHandler(this.ConsultarPuerto_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPuerto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvPuerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtFiltroNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFiltroCodigo;
        private System.Windows.Forms.Label label3;
        private PruebaButton btnBuscar;
        private PruebaButton btnCancel;
        private PruebaButton pruebaButton1;
        private PruebaButton pruebaButton2;
        private PruebaButton pruebaButton3;
    }
}
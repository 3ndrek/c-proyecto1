namespace Pav_TP.InterfacesDeUsuario.Barco
{
    partial class ConsultarBarco
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgvBarco = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altural = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eslora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desplazamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autonomia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantCamarotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantMaxPasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantMotores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantTripulantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnFiltro = new System.Windows.Forms.Button();
            this.TxtFiltroNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFiltroCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBarco)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnAgregar);
            this.groupBox2.Controls.Add(this.DgvBarco);
            this.groupBox2.Controls.Add(this.BtnEliminar);
            this.groupBox2.Controls.Add(this.BtnModificar);
            this.groupBox2.Location = new System.Drawing.Point(40, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 233);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados de la busqueda";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(250, 195);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 29;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DgvBarco
            // 
            this.DgvBarco.AllowUserToAddRows = false;
            this.DgvBarco.AllowUserToDeleteRows = false;
            this.DgvBarco.AllowUserToResizeRows = false;
            this.DgvBarco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBarco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Altural,
            this.Eslora,
            this.Manga,
            this.Desplazamiento,
            this.Autonomia,
            this.CantCamarotes,
            this.CantMaxPasajeros,
            this.CantMotores,
            this.CantTripulantes,
            this.Clasificacion,
            this.Seleccionar});
            this.DgvBarco.Location = new System.Drawing.Point(25, 28);
            this.DgvBarco.MultiSelect = false;
            this.DgvBarco.Name = "DgvBarco";
            this.DgvBarco.ReadOnly = true;
            this.DgvBarco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBarco.Size = new System.Drawing.Size(534, 150);
            this.DgvBarco.TabIndex = 26;
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
            // Altural
            // 
            this.Altural.HeaderText = "Altura";
            this.Altural.Name = "Altural";
            this.Altural.ReadOnly = true;
            // 
            // Eslora
            // 
            this.Eslora.HeaderText = "Eslora";
            this.Eslora.Name = "Eslora";
            this.Eslora.ReadOnly = true;
            // 
            // Manga
            // 
            this.Manga.HeaderText = "Manga";
            this.Manga.Name = "Manga";
            this.Manga.ReadOnly = true;
            // 
            // Desplazamiento
            // 
            this.Desplazamiento.HeaderText = "Desplazamiento";
            this.Desplazamiento.Name = "Desplazamiento";
            this.Desplazamiento.ReadOnly = true;
            // 
            // Autonomia
            // 
            this.Autonomia.HeaderText = "Autonomía";
            this.Autonomia.Name = "Autonomia";
            this.Autonomia.ReadOnly = true;
            // 
            // CantCamarotes
            // 
            this.CantCamarotes.HeaderText = "Cant. camarotes";
            this.CantCamarotes.Name = "CantCamarotes";
            this.CantCamarotes.ReadOnly = true;
            // 
            // CantMaxPasajeros
            // 
            this.CantMaxPasajeros.HeaderText = "Cant. Max. Pasajeros";
            this.CantMaxPasajeros.Name = "CantMaxPasajeros";
            this.CantMaxPasajeros.ReadOnly = true;
            // 
            // CantMotores
            // 
            this.CantMotores.HeaderText = "Cant. Motores";
            this.CantMotores.Name = "CantMotores";
            this.CantMotores.ReadOnly = true;
            // 
            // CantTripulantes
            // 
            this.CantTripulantes.HeaderText = "Cant. Tripulantes";
            this.CantTripulantes.Name = "CantTripulantes";
            this.CantTripulantes.ReadOnly = true;
            // 
            // Clasificacion
            // 
            this.Clasificacion.HeaderText = "Clasificación";
            this.Clasificacion.Name = "Clasificacion";
            this.Clasificacion.ReadOnly = true;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(481, 195);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 28;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(364, 195);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 27;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnFiltro);
            this.groupBox1.Controls.Add(this.TxtFiltroNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtFiltroCodigo);
            this.groupBox1.Location = new System.Drawing.Point(40, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 118);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por código o nombre";
            // 
            // BtnFiltro
            // 
            this.BtnFiltro.Location = new System.Drawing.Point(484, 83);
            this.BtnFiltro.Name = "BtnFiltro";
            this.BtnFiltro.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltro.TabIndex = 15;
            this.BtnFiltro.Text = "Filtrar";
            this.BtnFiltro.UseVisualStyleBackColor = true;
            this.BtnFiltro.Click += new System.EventHandler(this.BtnFiltro_Click);
            // 
            // TxtFiltroNombre
            // 
            this.TxtFiltroNombre.Location = new System.Drawing.Point(456, 31);
            this.TxtFiltroNombre.Name = "TxtFiltroNombre";
            this.TxtFiltroNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtFiltroNombre.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código";
            // 
            // TxtFiltroCodigo
            // 
            this.TxtFiltroCodigo.Location = new System.Drawing.Point(115, 31);
            this.TxtFiltroCodigo.Name = "TxtFiltroCodigo";
            this.TxtFiltroCodigo.Size = new System.Drawing.Size(100, 20);
            this.TxtFiltroCodigo.TabIndex = 12;
            this.TxtFiltroCodigo.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Consultar embarcación";
            // 
            // ConsultarBarco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "ConsultarBarco";
            this.Text = "ConsultarBarco";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultarBarco_FormClosing);
            this.Load += new System.EventHandler(this.ConsultarBarco_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBarco)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvBarco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altural;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eslora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desplazamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autonomia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantCamarotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantMaxPasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantMotores;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantTripulantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clasificacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtFiltroNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFiltroCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnFiltro;
        private System.Windows.Forms.Button BtnAgregar;
    }
}
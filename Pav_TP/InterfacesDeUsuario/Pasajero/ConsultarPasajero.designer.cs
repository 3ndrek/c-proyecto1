
using System;

namespace TrabajoPracticoPav
{
    partial class ConsultarPasajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarPasajero));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.btnModificar = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.btnEliminar = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.btnGuardar = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.GrillaPasajero = new System.Windows.Forms.DataGridView();
            this.tipo_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad_procedente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais_procedente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPasajero)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.GrillaPasajero);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.groupBox1.Location = new System.Drawing.Point(75, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "InformaciónPasajero";
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
            this.btnCancel.Location = new System.Drawing.Point(478, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 38);
            this.btnCancel.TabIndex = 78;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnModificar.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.btnModificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnModificar.BorderRadius = 20;
            this.btnModificar.BorderSize = 0;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(385, 184);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 38);
            this.btnModificar.TabIndex = 77;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.BackgroundColor = System.Drawing.Color.Red;
            this.btnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BorderRadius = 20;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(279, 184);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 38);
            this.btnEliminar.TabIndex = 76;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
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
            this.btnGuardar.Location = new System.Drawing.Point(170, 184);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 38);
            this.btnGuardar.TabIndex = 75;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // GrillaPasajero
            // 
            this.GrillaPasajero.AllowUserToAddRows = false;
            this.GrillaPasajero.AllowUserToDeleteRows = false;
            this.GrillaPasajero.AllowUserToResizeRows = false;
            this.GrillaPasajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaPasajero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipo_doc,
            this.num_doc,
            this.nombre,
            this.apellido,
            this.ciudad_procedente,
            this.pais_procedente,
            this.email,
            this.fechaNac,
            this.genero});
            this.GrillaPasajero.Location = new System.Drawing.Point(22, 28);
            this.GrillaPasajero.MultiSelect = false;
            this.GrillaPasajero.Name = "GrillaPasajero";
            this.GrillaPasajero.ReadOnly = true;
            this.GrillaPasajero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaPasajero.Size = new System.Drawing.Size(534, 150);
            this.GrillaPasajero.TabIndex = 30;
            // 
            // tipo_doc
            // 
            this.tipo_doc.HeaderText = "tipo_doc";
            this.tipo_doc.Name = "tipo_doc";
            this.tipo_doc.ReadOnly = true;
            // 
            // num_doc
            // 
            this.num_doc.HeaderText = "num_doc";
            this.num_doc.Name = "num_doc";
            this.num_doc.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // ciudad_procedente
            // 
            this.ciudad_procedente.HeaderText = "ciudad_procedente";
            this.ciudad_procedente.Name = "ciudad_procedente";
            this.ciudad_procedente.ReadOnly = true;
            // 
            // pais_procedente
            // 
            this.pais_procedente.HeaderText = "pais_procedente";
            this.pais_procedente.Name = "pais_procedente";
            this.pais_procedente.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // fechaNac
            // 
            this.fechaNac.HeaderText = "fechaNac";
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.ReadOnly = true;
            // 
            // genero
            // 
            this.genero.HeaderText = "genero";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            // 
            // TxtDni
            // 
            this.TxtDni.Location = new System.Drawing.Point(115, 31);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(121, 22);
            this.TxtDni.TabIndex = 31;
            this.TxtDni.Text = "0";
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Location = new System.Drawing.Point(19, 38);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(31, 16);
            this.dni.TabIndex = 20;
            this.dni.Text = "DNI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.TxtDni);
            this.groupBox2.Controls.Add(this.dni);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.groupBox2.Location = new System.Drawing.Point(75, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por numero de documento";
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
            this.btnBuscar.Location = new System.Drawing.Point(250, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 38);
            this.btnBuscar.TabIndex = 75;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.label3.Location = new System.Drawing.Point(215, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Consultar Informacion de pasajero";
            // 
            // ConsultarPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(210)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarPasajero";
            this.Text = "ConsultarPasajero";
            this.Load += new System.EventHandler(this.ConsultarPasajero_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPasajero)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.DataGridView GrillaPasajero;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad_procedente;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais_procedente;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private Pav_TP.InterfacesDeUsuario.PruebaButton btnBuscar;
        private Pav_TP.InterfacesDeUsuario.PruebaButton btnGuardar;
        private Pav_TP.InterfacesDeUsuario.PruebaButton btnModificar;
        private Pav_TP.InterfacesDeUsuario.PruebaButton btnEliminar;
        private Pav_TP.InterfacesDeUsuario.PruebaButton btnCancel;
    }
}
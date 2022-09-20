
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dni = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPasajero)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.GrillaPasajero);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Location = new System.Drawing.Point(40, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "InformaciónPasajero";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(481, 195);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 32;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
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
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Location = new System.Drawing.Point(250, 195);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(364, 195);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(291, 448);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // TxtDni
            // 
            this.TxtDni.Location = new System.Drawing.Point(115, 31);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(121, 20);
            this.TxtDni.TabIndex = 31;
            this.TxtDni.Text = "0";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(251, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Location = new System.Drawing.Point(19, 38);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(26, 13);
            this.dni.TabIndex = 20;
            this.dni.Text = "DNI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtDni);
            this.groupBox2.Controls.Add(this.dni);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Location = new System.Drawing.Point(40, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por numero de documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Consultar Informacion de pasajero";
            // 
            // ConsultarPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 501);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView GrillaPasajero;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad_procedente;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais_procedente;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
    }
}
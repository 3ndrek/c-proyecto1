
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarTripulante));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pruebaButton4 = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.pruebaButton3 = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.pruebaButton2 = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.btnGuardar = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.GrillaTripulante = new System.Windows.Forms.DataGridView();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jefe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtLegajo = new System.Windows.Forms.TextBox();
            this.genero = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pruebaButton1 = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTripulante)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pruebaButton4);
            this.groupBox1.Controls.Add(this.pruebaButton3);
            this.groupBox1.Controls.Add(this.pruebaButton2);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.GrillaTripulante);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.groupBox1.Location = new System.Drawing.Point(75, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 233);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Tripulante";
            // 
            // pruebaButton4
            // 
            this.pruebaButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.pruebaButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.pruebaButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pruebaButton4.BorderRadius = 20;
            this.pruebaButton4.BorderSize = 0;
            this.pruebaButton4.FlatAppearance.BorderSize = 0;
            this.pruebaButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pruebaButton4.ForeColor = System.Drawing.Color.White;
            this.pruebaButton4.Location = new System.Drawing.Point(478, 184);
            this.pruebaButton4.Name = "pruebaButton4";
            this.pruebaButton4.Size = new System.Drawing.Size(87, 38);
            this.pruebaButton4.TabIndex = 79;
            this.pruebaButton4.Text = "Cancelar";
            this.pruebaButton4.TextColor = System.Drawing.Color.White;
            this.pruebaButton4.UseVisualStyleBackColor = false;
            this.pruebaButton4.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pruebaButton3
            // 
            this.pruebaButton3.BackColor = System.Drawing.Color.DarkOrange;
            this.pruebaButton3.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.pruebaButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pruebaButton3.BorderRadius = 20;
            this.pruebaButton3.BorderSize = 0;
            this.pruebaButton3.FlatAppearance.BorderSize = 0;
            this.pruebaButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pruebaButton3.ForeColor = System.Drawing.Color.White;
            this.pruebaButton3.Location = new System.Drawing.Point(385, 184);
            this.pruebaButton3.Name = "pruebaButton3";
            this.pruebaButton3.Size = new System.Drawing.Size(87, 38);
            this.pruebaButton3.TabIndex = 78;
            this.pruebaButton3.Text = "Modificar";
            this.pruebaButton3.TextColor = System.Drawing.Color.White;
            this.pruebaButton3.UseVisualStyleBackColor = false;
            this.pruebaButton3.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.pruebaButton2.Location = new System.Drawing.Point(279, 184);
            this.pruebaButton2.Name = "pruebaButton2";
            this.pruebaButton2.Size = new System.Drawing.Size(87, 38);
            this.pruebaButton2.TabIndex = 77;
            this.pruebaButton2.Text = "Eliminar";
            this.pruebaButton2.TextColor = System.Drawing.Color.White;
            this.pruebaButton2.UseVisualStyleBackColor = false;
            this.pruebaButton2.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnGuardar.TabIndex = 76;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // GrillaTripulante
            // 
            this.GrillaTripulante.AllowUserToAddRows = false;
            this.GrillaTripulante.AllowUserToDeleteRows = false;
            this.GrillaTripulante.AllowUserToResizeRows = false;
            this.GrillaTripulante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaTripulante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.legajo,
            this.jefe,
            this.nombre,
            this.apellido,
            this.email,
            this.fechaNac,
            this.puesto});
            this.GrillaTripulante.Location = new System.Drawing.Point(25, 28);
            this.GrillaTripulante.MultiSelect = false;
            this.GrillaTripulante.Name = "GrillaTripulante";
            this.GrillaTripulante.ReadOnly = true;
            this.GrillaTripulante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaTripulante.Size = new System.Drawing.Size(534, 150);
            this.GrillaTripulante.TabIndex = 30;
            // 
            // legajo
            // 
            this.legajo.HeaderText = "legajo";
            this.legajo.Name = "legajo";
            this.legajo.ReadOnly = true;
            // 
            // jefe
            // 
            this.jefe.HeaderText = "jefe";
            this.jefe.Name = "jefe";
            this.jefe.ReadOnly = true;
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
            // puesto
            // 
            this.puesto.HeaderText = "puesto";
            this.puesto.Name = "puesto";
            this.puesto.ReadOnly = true;
            // 
            // TxtLegajo
            // 
            this.TxtLegajo.Location = new System.Drawing.Point(115, 31);
            this.TxtLegajo.Name = "TxtLegajo";
            this.TxtLegajo.Size = new System.Drawing.Size(100, 22);
            this.TxtLegajo.TabIndex = 23;
            this.TxtLegajo.Text = "0";
            // 
            // genero
            // 
            this.genero.AutoSize = true;
            this.genero.Location = new System.Drawing.Point(19, 38);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(50, 16);
            this.genero.TabIndex = 22;
            this.genero.Text = "Legajo";
            this.genero.Click += new System.EventHandler(this.genero_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pruebaButton1);
            this.groupBox2.Controls.Add(this.genero);
            this.groupBox2.Controls.Add(this.TxtLegajo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.groupBox2.Location = new System.Drawing.Point(75, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 103);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por legajo";
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
            this.pruebaButton1.Location = new System.Drawing.Point(248, 21);
            this.pruebaButton1.Name = "pruebaButton1";
            this.pruebaButton1.Size = new System.Drawing.Size(87, 38);
            this.pruebaButton1.TabIndex = 76;
            this.pruebaButton1.Text = "Buscar";
            this.pruebaButton1.TextColor = System.Drawing.Color.White;
            this.pruebaButton1.UseVisualStyleBackColor = false;
            this.pruebaButton1.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.label3.Location = new System.Drawing.Point(215, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Consultar Informacion de tripulante";
            // 
            // ConsultarTripulante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(210)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarTripulante";
            this.Text = "ConsultarTripulante";
            this.Load += new System.EventHandler(this.ConsultarTripulante_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTripulante)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtLegajo;
        private System.Windows.Forms.Label genero;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GrillaTripulante;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn jefe;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn puesto;
        private Pav_TP.InterfacesDeUsuario.PruebaButton pruebaButton1;
        private Pav_TP.InterfacesDeUsuario.PruebaButton btnGuardar;
        private Pav_TP.InterfacesDeUsuario.PruebaButton pruebaButton2;
        private Pav_TP.InterfacesDeUsuario.PruebaButton pruebaButton3;
        private Pav_TP.InterfacesDeUsuario.PruebaButton pruebaButton4;
    }
}
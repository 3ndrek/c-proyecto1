
namespace Pav_TP.InterfacesDeUsuario.Transacciones
{
    partial class ConsultarItinerario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarItinerario));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.TxtCod = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.DvgItinerarios = new System.Windows.Forms.DataGridView();
            this.Cod_Itinerario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_escala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPuerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvgItinerarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.label3.Location = new System.Drawing.Point(360, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(477, 33);
            this.label3.TabIndex = 30;
            this.label3.Text = "Consultar Informacion de itinerarios";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.TxtCod);
            this.groupBox2.Controls.Add(this.dni);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.groupBox2.Location = new System.Drawing.Point(112, 103);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(900, 158);
            this.groupBox2.TabIndex = 29;
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
            this.btnBuscar.Location = new System.Drawing.Point(474, 37);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(130, 58);
            this.btnBuscar.TabIndex = 75;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TxtCod
            // 
            this.TxtCod.Location = new System.Drawing.Point(272, 49);
            this.TxtCod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCod.Name = "TxtCod";
            this.TxtCod.Size = new System.Drawing.Size(180, 30);
            this.TxtCod.TabIndex = 31;
            this.TxtCod.Text = "0";
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Location = new System.Drawing.Point(28, 58);
            this.dni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(180, 25);
            this.dni.TabIndex = 20;
            this.dni.Text = "Código de itinerario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.DvgItinerarios);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.groupBox1.Location = new System.Drawing.Point(112, 302);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(900, 358);
            this.groupBox1.TabIndex = 28;
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
            this.btnCancel.Location = new System.Drawing.Point(717, 283);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 58);
            this.btnCancel.TabIndex = 78;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DvgItinerarios
            // 
            this.DvgItinerarios.AllowUserToAddRows = false;
            this.DvgItinerarios.AllowUserToDeleteRows = false;
            this.DvgItinerarios.AllowUserToResizeRows = false;
            this.DvgItinerarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgItinerarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Itinerario,
            this.Categoria,
            this.Descripcion,
            this.Num_escala,
            this.NomPais,
            this.NomPuerto});
            this.DvgItinerarios.Location = new System.Drawing.Point(33, 43);
            this.DvgItinerarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DvgItinerarios.MultiSelect = false;
            this.DvgItinerarios.Name = "DvgItinerarios";
            this.DvgItinerarios.ReadOnly = true;
            this.DvgItinerarios.RowHeadersWidth = 62;
            this.DvgItinerarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DvgItinerarios.Size = new System.Drawing.Size(801, 231);
            this.DvgItinerarios.TabIndex = 30;
            // 
            // Cod_Itinerario
            // 
            this.Cod_Itinerario.HeaderText = "Cod_Itinerario";
            this.Cod_Itinerario.MinimumWidth = 8;
            this.Cod_Itinerario.Name = "Cod_Itinerario";
            this.Cod_Itinerario.ReadOnly = true;
            this.Cod_Itinerario.Width = 150;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 8;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 150;
            // 
            // Num_escala
            // 
            this.Num_escala.HeaderText = "Num_escala";
            this.Num_escala.MinimumWidth = 8;
            this.Num_escala.Name = "Num_escala";
            this.Num_escala.ReadOnly = true;
            this.Num_escala.Width = 150;
            // 
            // NomPais
            // 
            this.NomPais.HeaderText = "NomPais";
            this.NomPais.MinimumWidth = 8;
            this.NomPais.Name = "NomPais";
            this.NomPais.ReadOnly = true;
            this.NomPais.Width = 150;
            // 
            // NomPuerto
            // 
            this.NomPuerto.HeaderText = "NomPuerto";
            this.NomPuerto.MinimumWidth = 8;
            this.NomPuerto.Name = "NomPuerto";
            this.NomPuerto.ReadOnly = true;
            this.NomPuerto.Width = 150;
            // 
            // ConsultarItinerario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(210)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1134, 692);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsultarItinerario";
            this.Text = "ConsultarItinerario";
            this.Load += new System.EventHandler(this.ConsultarItinerario_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DvgItinerarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private PruebaButton btnBuscar;
        private System.Windows.Forms.TextBox TxtCod;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.GroupBox groupBox1;
        private PruebaButton btnCancel;
        private System.Windows.Forms.DataGridView DvgItinerarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Itinerario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_escala;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPuerto;
    }
}
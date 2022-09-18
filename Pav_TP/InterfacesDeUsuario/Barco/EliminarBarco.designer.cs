namespace Pav_TP.InterfacesDeUsuario.Barco
{
    partial class EliminarBarco
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(53, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 206);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados de la busqueda";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.Location = new System.Drawing.Point(26, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(534, 150);
            this.dataGridView1.TabIndex = 25;
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
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(367, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(237, 392);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(53, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 73);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por código o nombre";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(456, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Eliminar embarcación";
            // 
            // EliminarBarco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 428);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "EliminarBarco";
            this.Text = "EliminarBarco";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}
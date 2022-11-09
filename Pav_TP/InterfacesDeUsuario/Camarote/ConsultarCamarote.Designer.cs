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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarCamarote));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbNavio = new System.Windows.Forms.ComboBox();
            this.CmbCubierta = new System.Windows.Forms.ComboBox();
            this.TxtNro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GrillaCamarotes = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.pruebaButton1 = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.pruebaButton2 = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.pruebaButton3 = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.pruebaButton4 = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaCamarotes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Navio*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cubierta*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero de Camarote";
            // 
            // CmbNavio
            // 
            this.CmbNavio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbNavio.FormattingEnabled = true;
            this.CmbNavio.Location = new System.Drawing.Point(195, 31);
            this.CmbNavio.Margin = new System.Windows.Forms.Padding(2);
            this.CmbNavio.Name = "CmbNavio";
            this.CmbNavio.Size = new System.Drawing.Size(108, 24);
            this.CmbNavio.TabIndex = 4;
            // 
            // CmbCubierta
            // 
            this.CmbCubierta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCubierta.FormattingEnabled = true;
            this.CmbCubierta.Location = new System.Drawing.Point(195, 62);
            this.CmbCubierta.Margin = new System.Windows.Forms.Padding(2);
            this.CmbCubierta.Name = "CmbCubierta";
            this.CmbCubierta.Size = new System.Drawing.Size(108, 24);
            this.CmbCubierta.TabIndex = 5;
            this.CmbCubierta.Click += new System.EventHandler(this.CmbCubierta_Click);
            // 
            // TxtNro
            // 
            this.TxtNro.Location = new System.Drawing.Point(195, 97);
            this.TxtNro.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNro.Name = "TxtNro";
            this.TxtNro.Size = new System.Drawing.Size(108, 22);
            this.TxtNro.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pruebaButton1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CmbNavio);
            this.groupBox1.Controls.Add(this.TxtNro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CmbCubierta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.groupBox1.Location = new System.Drawing.Point(17, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(337, 183);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos que desea consultar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Obligatorios: *";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pruebaButton2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.groupBox2.Location = new System.Drawing.Point(394, 46);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(332, 86);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desea registrar un nuevo camarote?";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pruebaButton3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.groupBox3.Location = new System.Drawing.Point(394, 143);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(332, 86);
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
            this.label5.Size = new System.Drawing.Size(307, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Seleccione uno o más camarotes para eliminarlos";
            // 
            // GrillaCamarotes
            // 
            this.GrillaCamarotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaCamarotes.Location = new System.Drawing.Point(17, 242);
            this.GrillaCamarotes.Margin = new System.Windows.Forms.Padding(2);
            this.GrillaCamarotes.Name = "GrillaCamarotes";
            this.GrillaCamarotes.RowHeadersWidth = 51;
            this.GrillaCamarotes.RowTemplate.Height = 24;
            this.GrillaCamarotes.Size = new System.Drawing.Size(728, 164);
            this.GrillaCamarotes.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.label6.Location = new System.Drawing.Point(262, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 3, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(203, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Consultar camarote";
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
            this.pruebaButton1.Location = new System.Drawing.Point(200, 130);
            this.pruebaButton1.Name = "pruebaButton1";
            this.pruebaButton1.Size = new System.Drawing.Size(87, 38);
            this.pruebaButton1.TabIndex = 77;
            this.pruebaButton1.Text = "Buscar";
            this.pruebaButton1.TextColor = System.Drawing.Color.White;
            this.pruebaButton1.UseVisualStyleBackColor = false;
            this.pruebaButton1.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // pruebaButton2
            // 
            this.pruebaButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.pruebaButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.pruebaButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pruebaButton2.BorderRadius = 20;
            this.pruebaButton2.BorderSize = 0;
            this.pruebaButton2.FlatAppearance.BorderSize = 0;
            this.pruebaButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pruebaButton2.ForeColor = System.Drawing.Color.White;
            this.pruebaButton2.Location = new System.Drawing.Point(121, 31);
            this.pruebaButton2.Name = "pruebaButton2";
            this.pruebaButton2.Size = new System.Drawing.Size(87, 38);
            this.pruebaButton2.TabIndex = 78;
            this.pruebaButton2.Text = "Agregar";
            this.pruebaButton2.TextColor = System.Drawing.Color.White;
            this.pruebaButton2.UseVisualStyleBackColor = false;
            this.pruebaButton2.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // pruebaButton3
            // 
            this.pruebaButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.pruebaButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.pruebaButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pruebaButton3.BorderRadius = 20;
            this.pruebaButton3.BorderSize = 0;
            this.pruebaButton3.FlatAppearance.BorderSize = 0;
            this.pruebaButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pruebaButton3.ForeColor = System.Drawing.Color.White;
            this.pruebaButton3.Location = new System.Drawing.Point(121, 46);
            this.pruebaButton3.Name = "pruebaButton3";
            this.pruebaButton3.Size = new System.Drawing.Size(87, 38);
            this.pruebaButton3.TabIndex = 79;
            this.pruebaButton3.Text = "Eliminar";
            this.pruebaButton3.TextColor = System.Drawing.Color.White;
            this.pruebaButton3.UseVisualStyleBackColor = false;
            this.pruebaButton3.Click += new System.EventHandler(this.BtnEliminar_Click);
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
            this.pruebaButton4.Location = new System.Drawing.Point(639, 411);
            this.pruebaButton4.Name = "pruebaButton4";
            this.pruebaButton4.Size = new System.Drawing.Size(87, 38);
            this.pruebaButton4.TabIndex = 79;
            this.pruebaButton4.Text = "Cancelar";
            this.pruebaButton4.TextColor = System.Drawing.Color.White;
            this.pruebaButton4.UseVisualStyleBackColor = false;
            this.pruebaButton4.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // ConsultarCamarote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(210)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.pruebaButton4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GrillaCamarotes);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultarCamarote";
            this.Text = "ConsultarCamarote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultarCamarote_FormClosing);
            this.Load += new System.EventHandler(this.ConsultarCamarote_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaCamarotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbNavio;
        private System.Windows.Forms.ComboBox CmbCubierta;
        private System.Windows.Forms.TextBox TxtNro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView GrillaCamarotes;
        private System.Windows.Forms.Label label6;
        private PruebaButton pruebaButton1;
        private PruebaButton pruebaButton2;
        private PruebaButton pruebaButton3;
        private PruebaButton pruebaButton4;
    }
}
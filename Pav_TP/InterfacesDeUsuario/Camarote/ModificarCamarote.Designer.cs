namespace Pav_TP.InterfacesDeUsuario.Camarote
{
    partial class ModificarCamarote
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbNavio = new System.Windows.Forms.ComboBox();
            this.CmbCubierta = new System.Windows.Forms.ComboBox();
            this.CmbNroCamarote = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.CmbUbicacion = new System.Windows.Forms.ComboBox();
            this.Txtcamas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbNroCamarote);
            this.groupBox1.Controls.Add(this.CmbCubierta);
            this.groupBox1.Controls.Add(this.CmbNavio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione los datos del camarote que desea modificar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Navio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cubierta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de camarote";
            // 
            // CmbNavio
            // 
            this.CmbNavio.FormattingEnabled = true;
            this.CmbNavio.Location = new System.Drawing.Point(153, 24);
            this.CmbNavio.Name = "CmbNavio";
            this.CmbNavio.Size = new System.Drawing.Size(121, 24);
            this.CmbNavio.TabIndex = 3;
            // 
            // CmbCubierta
            // 
            this.CmbCubierta.FormattingEnabled = true;
            this.CmbCubierta.Location = new System.Drawing.Point(153, 65);
            this.CmbCubierta.Name = "CmbCubierta";
            this.CmbCubierta.Size = new System.Drawing.Size(121, 24);
            this.CmbCubierta.TabIndex = 4;
            this.CmbCubierta.Click += new System.EventHandler(this.CmbCubierta_Click);
            // 
            // CmbNroCamarote
            // 
            this.CmbNroCamarote.FormattingEnabled = true;
            this.CmbNroCamarote.Location = new System.Drawing.Point(153, 118);
            this.CmbNroCamarote.Name = "CmbNroCamarote";
            this.CmbNroCamarote.Size = new System.Drawing.Size(121, 24);
            this.CmbNroCamarote.TabIndex = 5;
            this.CmbNroCamarote.Click += new System.EventHandler(this.CmbNroCamarote_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Txtcamas);
            this.groupBox2.Controls.Add(this.CmbTipo);
            this.groupBox2.Controls.Add(this.CmbUbicacion);
            this.groupBox2.Location = new System.Drawing.Point(12, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingrese los nuevos datos del camarote";
            // 
            // CmbTipo
            // 
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Location = new System.Drawing.Point(168, 40);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(121, 24);
            this.CmbTipo.TabIndex = 6;
            this.CmbTipo.Click += new System.EventHandler(this.CmbTipo_Click);
            // 
            // CmbUbicacion
            // 
            this.CmbUbicacion.FormattingEnabled = true;
            this.CmbUbicacion.Location = new System.Drawing.Point(168, 96);
            this.CmbUbicacion.Name = "CmbUbicacion";
            this.CmbUbicacion.Size = new System.Drawing.Size(121, 24);
            this.CmbUbicacion.TabIndex = 7;
            this.CmbUbicacion.Click += new System.EventHandler(this.CmbUbicacion_Click);
            // 
            // Txtcamas
            // 
            this.Txtcamas.Location = new System.Drawing.Point(168, 142);
            this.Txtcamas.Name = "Txtcamas";
            this.Txtcamas.Size = new System.Drawing.Size(100, 22);
            this.Txtcamas.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo de camarote";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ubicacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cantidad de camas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(397, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Esta seguro de que desea modificar los datos de este camarote?";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(210, 459);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 3;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(317, 459);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // ModificarCamarote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 502);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificarCamarote";
            this.Text = "Modificar Camarote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificarCamarote_FormClosing);
            this.Load += new System.EventHandler(this.ModificarCamarote_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbNroCamarote;
        private System.Windows.Forms.ComboBox CmbCubierta;
        private System.Windows.Forms.ComboBox CmbNavio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtcamas;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.ComboBox CmbUbicacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}
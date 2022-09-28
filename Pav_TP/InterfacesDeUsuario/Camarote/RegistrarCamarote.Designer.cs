namespace Pav_TP.InterfacesDeUsuario.Camarote
{
    partial class RegistrarCamarote
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
            this.TxtCantCamas = new System.Windows.Forms.TextBox();
            this.TxtNumCamarote = new System.Windows.Forms.TextBox();
            this.CmbUbicacion = new System.Windows.Forms.ComboBox();
            this.CmbTipoCam = new System.Windows.Forms.ComboBox();
            this.CmbCubierta = new System.Windows.Forms.ComboBox();
            this.CmbNavio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtCantCamas);
            this.groupBox1.Controls.Add(this.TxtNumCamarote);
            this.groupBox1.Controls.Add(this.CmbUbicacion);
            this.groupBox1.Controls.Add(this.CmbTipoCam);
            this.groupBox1.Controls.Add(this.CmbCubierta);
            this.groupBox1.Controls.Add(this.CmbNavio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 283);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del camarote";
            // 
            // TxtCantCamas
            // 
            this.TxtCantCamas.Location = new System.Drawing.Point(136, 247);
            this.TxtCantCamas.Name = "TxtCantCamas";
            this.TxtCantCamas.Size = new System.Drawing.Size(100, 22);
            this.TxtCantCamas.TabIndex = 11;
            // 
            // TxtNumCamarote
            // 
            this.TxtNumCamarote.Location = new System.Drawing.Point(148, 112);
            this.TxtNumCamarote.Name = "TxtNumCamarote";
            this.TxtNumCamarote.Size = new System.Drawing.Size(100, 22);
            this.TxtNumCamarote.TabIndex = 10;
            // 
            // CmbUbicacion
            // 
            this.CmbUbicacion.DisplayMember = "num";
            this.CmbUbicacion.FormattingEnabled = true;
            this.CmbUbicacion.Location = new System.Drawing.Point(84, 202);
            this.CmbUbicacion.Name = "CmbUbicacion";
            this.CmbUbicacion.Size = new System.Drawing.Size(121, 24);
            this.CmbUbicacion.TabIndex = 9;
            this.CmbUbicacion.ValueMember = "num";
            // 
            // CmbTipoCam
            // 
            this.CmbTipoCam.DisplayMember = "tipo";
            this.CmbTipoCam.FormattingEnabled = true;
            this.CmbTipoCam.Location = new System.Drawing.Point(127, 155);
            this.CmbTipoCam.Name = "CmbTipoCam";
            this.CmbTipoCam.Size = new System.Drawing.Size(141, 24);
            this.CmbTipoCam.TabIndex = 8;
            this.CmbTipoCam.ValueMember = "tipo";
            // 
            // CmbCubierta
            // 
            this.CmbCubierta.DisplayMember = "num_cubierta";
            this.CmbCubierta.FormattingEnabled = true;
            this.CmbCubierta.Location = new System.Drawing.Point(84, 68);
            this.CmbCubierta.Name = "CmbCubierta";
            this.CmbCubierta.Size = new System.Drawing.Size(184, 24);
            this.CmbCubierta.TabIndex = 7;
            this.CmbCubierta.ValueMember = "num_cubierta";
            this.CmbCubierta.Click += new System.EventHandler(this.CmbCubierta_Click);
            // 
            // CmbNavio
            // 
            this.CmbNavio.DisplayMember = "codigo_navio";
            this.CmbNavio.FormattingEnabled = true;
            this.CmbNavio.Location = new System.Drawing.Point(84, 29);
            this.CmbNavio.Name = "CmbNavio";
            this.CmbNavio.Size = new System.Drawing.Size(121, 24);
            this.CmbNavio.TabIndex = 6;
            this.CmbNavio.ValueMember = "codigo_navio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad de camas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ubicacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de camarote";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de camarote";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cubierta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Navio";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(173, 345);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 30);
            this.BtnAceptar.TabIndex = 2;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(260, 345);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 30);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Esta seguro de que quiere registrar este camarote?";
            // 
            // RegistrarCamarote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 389);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrarCamarote";
            this.Text = "RegistrarCamarote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrarCamarote_FormClosing);
            this.Load += new System.EventHandler(this.RegistrarCamarote_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbUbicacion;
        private System.Windows.Forms.ComboBox CmbTipoCam;
        private System.Windows.Forms.ComboBox CmbCubierta;
        private System.Windows.Forms.ComboBox CmbNavio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCantCamas;
        private System.Windows.Forms.TextBox TxtNumCamarote;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label7;
    }
}
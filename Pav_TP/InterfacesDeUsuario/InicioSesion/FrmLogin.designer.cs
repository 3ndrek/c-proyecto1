namespace PAV1
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblUSR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContrasenia = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.BtnSalir = new Pav_TP.InterfacesDeUsuario.PruebaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUSR
            // 
            this.lblUSR.AutoSize = true;
            this.lblUSR.BackColor = System.Drawing.Color.Transparent;
            this.lblUSR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSR.ForeColor = System.Drawing.Color.Silver;
            this.lblUSR.Location = new System.Drawing.Point(58, 224);
            this.lblUSR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUSR.Name = "lblUSR";
            this.lblUSR.Size = new System.Drawing.Size(66, 21);
            this.lblUSR.TabIndex = 0;
            this.lblUSR.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(58, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(62, 247);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(245, 20);
            this.TxtUsuario.TabIndex = 2;
            // 
            // TxtContrasenia
            // 
            this.TxtContrasenia.Location = new System.Drawing.Point(62, 316);
            this.TxtContrasenia.Margin = new System.Windows.Forms.Padding(2);
            this.TxtContrasenia.Name = "TxtContrasenia";
            this.TxtContrasenia.Size = new System.Drawing.Size(245, 20);
            this.TxtContrasenia.TabIndex = 3;
            this.TxtContrasenia.UseSystemPasswordChar = true;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BtnIngresar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BtnIngresar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnIngresar.BorderRadius = 20;
            this.BtnIngresar.BorderSize = 0;
            this.BtnIngresar.FlatAppearance.BorderSize = 0;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.Color.White;
            this.BtnIngresar.Location = new System.Drawing.Point(82, 386);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(79, 38);
            this.BtnIngresar.TabIndex = 7;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.TextColor = System.Drawing.Color.White;
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BtnSalir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BtnSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnSalir.BorderRadius = 20;
            this.BtnSalir.BorderSize = 0;
            this.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(196, 386);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(79, 38);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "Cerrar";
            this.BtnSalir.TextColor = System.Drawing.Color.White;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 160);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(373, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TxtContrasenia);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUSR);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmLogin";
            this.Text = "Iniciar Sesion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUSR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContrasenia;
        private Pav_TP.InterfacesDeUsuario.PruebaButton BtnIngresar;
        private Pav_TP.InterfacesDeUsuario.PruebaButton BtnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}



namespace TrabajoPracticoPav
{
    partial class RegistrarPasajero
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPasajero));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtApe = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxDni = new System.Windows.Forms.ComboBox();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cod = new System.Windows.Forms.Label();
            this.btnedit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCiudad = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(214, 374);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(316, 374);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Salir";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 685);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 685);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxCiudad);
            this.groupBox2.Controls.Add(this.btnedit);
            this.groupBox2.Controls.Add(this.cod);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.TxtDni);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBoxGenero);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBoxPais);
            this.groupBox2.Controls.Add(this.comboBoxDni);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TxtNom);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TxtApe);
            this.groupBox2.Controls.Add(this.TxtEmail);
            this.groupBox2.Location = new System.Drawing.Point(27, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 304);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Pasajeros";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(141, 177);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(121, 20);
            this.TxtEmail.TabIndex = 30;
            // 
            // TxtApe
            // 
            this.TxtApe.Location = new System.Drawing.Point(141, 76);
            this.TxtApe.Name = "TxtApe";
            this.TxtApe.Size = new System.Drawing.Size(121, 20);
            this.TxtApe.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Fecha de Nacimiento";
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(141, 40);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(121, 20);
            this.TxtNom.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Apellido";
            // 
            // comboBoxDni
            // 
            this.comboBoxDni.FormattingEnabled = true;
            this.comboBoxDni.Location = new System.Drawing.Point(141, 112);
            this.comboBoxDni.Name = "comboBoxDni";
            this.comboBoxDni.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDni.TabIndex = 33;
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.Location = new System.Drawing.Point(391, 180);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPais.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Tipo DNI";
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Location = new System.Drawing.Point(141, 210);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGenero.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "DNI";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(141, 246);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker2.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Genero";
            // 
            // TxtDni
            // 
            this.TxtDni.Location = new System.Drawing.Point(141, 145);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(121, 20);
            this.TxtDni.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(346, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 98);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // cod
            // 
            this.cod.AutoSize = true;
            this.cod.Location = new System.Drawing.Point(277, 180);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(76, 13);
            this.cod.TabIndex = 42;
            this.cod.Text = "País de origen";
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(361, 143);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 43;
            this.btnedit.Text = "Editar";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Ciudad de origen\r\n";
            // 
            // comboBoxCiudad
            // 
            this.comboBoxCiudad.FormattingEnabled = true;
            this.comboBoxCiudad.Location = new System.Drawing.Point(391, 211);
            this.comboBoxCiudad.Name = "comboBoxCiudad";
            this.comboBoxCiudad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCiudad.TabIndex = 44;
            // 
            // RegistrarPasajero
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(620, 464);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGuardar);
            this.Name = "RegistrarPasajero";
            this.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.Text = "RegistrarPasajero";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Label cod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPais;
        private System.Windows.Forms.ComboBox comboBoxDni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtApe;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCiudad;
    }
}


namespace Pav_TP.ReportesYSalidas.TicketReservacion
{
    partial class CargaTicket
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
            this.RwTicket = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RwTicket
            // 
            this.RwTicket.LocalReport.ReportEmbeddedResource = "Pav_TP.ReportesYSalidas.TicketReservacion.TicketReservaConfirmada.rdlc";
            this.RwTicket.Location = new System.Drawing.Point(8, 8);
            this.RwTicket.Margin = new System.Windows.Forms.Padding(2);
            this.RwTicket.Name = "RwTicket";
            this.RwTicket.ServerReport.BearerToken = null;
            this.RwTicket.Size = new System.Drawing.Size(684, 462);
            this.RwTicket.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(617, 489);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // CargaTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 524);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RwTicket);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CargaTicket";
            this.Text = "CargaTicket";
            this.Load += new System.EventHandler(this.CargaTicket_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RwTicket;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnCancelar;
    }
}
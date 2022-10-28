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
            this.SuspendLayout();
            // 
            // RwTicket
            // 
            this.RwTicket.LocalReport.ReportEmbeddedResource = "Pav_TP.ReportesYSalidas.TicketReservacion.TicketReservaConfirmada.rdlc";
            this.RwTicket.Location = new System.Drawing.Point(12, 12);
            this.RwTicket.Name = "RwTicket";
            this.RwTicket.ServerReport.BearerToken = null;
            this.RwTicket.Size = new System.Drawing.Size(776, 414);
            this.RwTicket.TabIndex = 0;
            // 
            // CargaTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RwTicket);
            this.Name = "CargaTicket";
            this.Text = "CargaTicket";
            this.Load += new System.EventHandler(this.CargaTicket_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RwTicket;
    }
}
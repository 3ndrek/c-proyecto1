using Microsoft.Reporting.WinForms;
using Pav_TP.Entidades;
using Pav_TP.InterfacesDeUsuario.Transacciones;
using Pav_TP.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pav_TP.ReportesYSalidas.TicketReservacion
{
    public partial class CargaTicket : Form
    {
        private static BarcosServicios barcosServicios;
        private static TipoDocServicio tipoDocServicio;
        public CargaTicket()
        {
            InitializeComponent();
            barcosServicios = new BarcosServicios();
            tipoDocServicio = new TipoDocServicio();
        }

        private string GetNombreBarco(int codigo_barco)
        {
            var barcos = barcosServicios.GetBarcos();
            foreach (Barco barco in barcos)
            {
                if (barco.Codigo == codigo_barco)
                {
                    return barco.Nombre.ToString();
                }

            }
            var nombreDefc = "no se encontró el barco";
            return nombreDefc;
        }

        public void CargarTicket(Pasajero pasajero, Reservaciones reservaciones)
        {
            this.RwTicket.LocalReport.DataSources.Clear();
            
            var nro_barco = reservaciones.cod_navio;
            var nombreBarco = GetNombreBarco(nro_barco);

            var nro_tipo_doc = pasajero.tipo_doc;
            var tipo = getTipos(nro_tipo_doc);

            var parametros = new List<ReportParameter>()
            {
                new ReportParameter("NombreReserva", pasajero.nombre),
                new ReportParameter("apellidoReserva",pasajero.apellido ),
                new ReportParameter("tipo_documento",tipo),
                new ReportParameter("NroDoumento",pasajero.num_doc.ToString()),
                new ReportParameter("nro_reservacion",2.ToString()),
                new ReportParameter("fecha_viaje", reservaciones.fecha_viaje.ToString("dd/MM/yyyy hh:mm")),
                new ReportParameter("precio_reserva", reservaciones.monto.ToString()),
                new ReportParameter("cant_camas", reservaciones.cama_ocupada.ToString()),
                new ReportParameter("nombreNavio",nombreBarco),
                new ReportParameter("num_cubierta", reservaciones.num_cubierta.ToString()),
                new ReportParameter("num_camarote",reservaciones.num_camarote.ToString())

            };
            this.RwTicket.LocalReport.SetParameters(parametros);
            this.RwTicket.RefreshReport();
        }

        private string getTipos(int nro_tipo_doc)
        {
            var tipos = tipoDocServicio.GetTipos();

            foreach (TipoDoc tipo in tipos)
            {
                if (tipo.tipo == nro_tipo_doc)
                {
                    return tipo.desc;
                }
            }
            return null;
        }
        /*
        private void EnviarMail(Pasajero pasajero, Reservaciones reserva) 
        {
            RwTicket.Report = ".\\ReportesYSalidas\\TicketReservacion\\TicketReservaConfirmada.rdlc";
            var bytes = RwTicket.ren;


            MailMessage mail = new MailMessage();
            mail.To.Add();
            mail.From = new MailAddress("correo_prueba@servidor.dominio");
            mail.Subject = Asunto;
            mail.Body = CuerpoMensaje;
            mail.Priority = MailPriority.High;
            mail.IsBodyHtml = true;

            mail.AttachmentFiles.Add(ExportReportToPDF("Invoice.pdf"));

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.servidor";
            smtp.Credentials = new
            System.Net.NetworkCredential("correo_prueba@servidor.dominio", "******");
            smtp.EnableSsl = true;
            smtp.Send(mail);

        }


        */


        private void CargaTicket_Load(object sender, EventArgs e)
        {

        }

       
    }
}

using Pav_TP.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Pav_TP.Servicios
{
    internal class EnvioMail
    {
        private BarcosServicios barcosServicios;
        private static ReservacionesServicios reservaciones;
        public EnvioMail()
        {
            barcosServicios = new BarcosServicios();
            reservaciones = new ReservacionesServicios();
        }


        public void EnviarMail( Reservaciones reservacion, Pasajero pasajero)
            {

            var EmailDestino = reservaciones.buscarMail(pasajero);

            var nro_barco = reservacion.cod_navio;
            var nombreBarc = GetNombreBarco(nro_barco);

            var nro_reserva = reservaciones.GetNroReservacion(reservacion);


            var EmailOrigen = "seastarpav122022@gmail.com";
                var contraseña = "cdhghabwpxpwvjwv";


                var CuerpoMail = $@" <html> <body> <h1 style= >Boleteria SeaStar </h1> <br>  " +
                    $@" <p> <b> Querido Pasajero:{pasajero.nombre}" + " " + $" {pasajero.apellido} </b> </p>" +
                    $@" <p> DNI: {pasajero.num_doc} </p>" +
                    $@" <P> su numero de reserva: {nro_reserva} </P>" + // cambiar cuando pase el nro de reservacion 

                    $@" <P> Con fecha de salida {reservacion.fecha_viaje.ToString("dd/MM/yyyy hh:mm")}   </P>" +
                    $@" <P> Camarote: {reservacion.num_camarote} </P>" +
                    $@" <p> Del navío: {nombreBarc} </p>" +
                    $@" <p> nro de cubierta: {reservacion.num_cubierta} </p>" +
                    $@" <br>" +
                    $@" <h2 style => Fue confirmado correctamente</h2>" +
                    $@" <br>" + $"<p> Monto total: {reservacion.monto.ToString()} por ocupar {reservacion.cama_ocupada} camas </p> </body> </html> ";



                MailMessage mailMessage = new MailMessage(EmailOrigen,EmailDestino , "Confirmación de reserva ", CuerpoMail);

                mailMessage.IsBodyHtml = true;

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential(EmailOrigen, contraseña);

                try
                {
                    smtpClient.Send(mailMessage);

                }
                catch (Exception)
                {

                    throw;
                }

                smtpClient.Dispose();


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


    }
}

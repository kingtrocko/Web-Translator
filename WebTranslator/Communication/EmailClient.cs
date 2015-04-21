using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;

namespace WebTranslator.Communication
{
    public static class EmailClient
    {
        static EmailClient()
        {
 
        }

        public static bool SendEmail()
        {
            try
            {
                var fromAddress = new MailAddress("nuevotraductor@gmail.com", "Nuevo Traductor");
                var toAddress = new MailAddress("nahum_fabian13@hotmail.com", "Santiago");
                const string fromPassword = "nahum15eduardo";
                const string subject = "Traduccion enviada por un amigo";
                const string body = "Este es un mensaje de pruebas.";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }


                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
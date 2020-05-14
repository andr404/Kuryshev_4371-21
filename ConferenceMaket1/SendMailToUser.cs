using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Conference
{
    class SendMailToUser
    {
        static string iSpeakEmail = "ispeakknitu";
        static string iSpeakPass = "Minadmin1";

        static void SendEmail(string email, string title, string text)
        {
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(iSpeakEmail + "@mail.ru");
            mail.To.Add(new MailAddress(email));
            mail.Subject = title;
            mail.Body = text;

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.mail.ru";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(iSpeakEmail, iSpeakPass);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Send(mail);
            mail.Dispose();
        }

        public static void EditPasswordComplited(string email)
        {
            SendEmail(email, "Изменение пароля", "Пароль успешно изменен!\nС уважением, iSpeak");
        }

    }
}

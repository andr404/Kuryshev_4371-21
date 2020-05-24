using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conference
{
    static class SendMailToUser
    {
        static string iSpeakEmail = "ispeakknitu";
        static string iSpeakPass = "Minadmin1";

        static void SendEmail(string email, string title, string text)
        {
            try
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
            catch
            {
                var user = BD.GetUserWithoutPass(email);
                MessageBox.Show("Ошибка, письмо посетителю не отправлено на адрес: " + email + "\n Если изменение серьезное, позвоните ему лично: " + user.Phone.ToString());
            }
        }

        public static void EditPasswordComplited(string email)
        {
            SendEmail(email, "Изменение пароля", "Пароль успешно изменен!\nС уважением, iSpeak");
        }
        public static void EditLoginComplited(string email)
        {
            SendEmail(email, "Редактирование аккаунта", "Настройки аккаунта были изменены!\nС уважением, iSpeak");
        }
        public static void SendConferenceChange(string email, string confName)
        {
            SendEmail(email, "Изменение в конференции, на которую вы записаны",
                string.Format("В конференции {0}, на которую вы записаны, произошли изменения.\nПожалуйста, ознакомьтесь с изменениями в приложении.\nС уважением, iSpeak", confName));
        }

        public static void SendConferenceDeleted(string email)
        {
            SendEmail(email, "Конференция отменена",
                "Одна из конференций, на которую вы записаны, была отменена.\nПожалуйста, ознакомьтесь с изменениями в приложении.\nС уважением, iSpeak");
        }
        public static void ForgetPass(string email, int code)
        {
            SendEmail(email, "Восстановление пароля", "Ваш код: " + code.ToString());
        }

    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace PledDream.Helpers
{
    public static class EmailHelper
    {
        public static bool SendRepairPasswordMail(string email, string password)
        {
            return SendMail(email, "Ваш пароль для доступа к порталу службы по работе с персоналом ЕЭК: " + password, "Восстановление пароля");
        }
        public static bool SendNewPasswordMail(string email, string password)
        {
            return SendMail(email, "Ваш пароль для доступа к порталу службы по работе с персоналом ЕЭК: " + password, "Изменение пароля");
        }

        public static bool SendMail(string email, string strMessage = "", string subject = "Новый заказ с сайта PledDream.ru")
        {
            //try
            //{
                SmtpClient client = new SmtpClient("mail.pleddream.ru", 587);
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("postmaster@pleddream.ru", "Zj7!vOCp");
                MailAddress from = new MailAddress("postmaster@pleddream.ru", "Pled Dream", System.Text.Encoding.UTF8);
                MailAddress to = new MailAddress(email);
                MailMessage message = new MailMessage(from, to);
                message.Body = strMessage;
                message.BodyEncoding = System.Text.Encoding.UTF8;
                message.Subject = subject;
                message.SubjectEncoding = System.Text.Encoding.UTF8;

                client.Send(message);

                message.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    return true;
            //}

            //using (MailMessage mm = new MailMessage("postmaster@pleddream.ru", email))
            //{
            //    mm.Subject = subject;
            //    mm.Body = strMessage;
            //    mm.IsBodyHtml = false;
            //    using (SmtpClient sc = new SmtpClient("smtp.yandex.ru", 587))
            //    {
            //        sc.EnableSsl = true;
            //        sc.DeliveryMethod = SmtpDeliveryMethod.Network;
            //        sc.UseDefaultCredentials = false;
            //        sc.Credentials = new NetworkCredential("testquartatest@yandex.ru", "testtestquarta");
            //        sc.Send(mm);
            //    }
            //}
            return true;
        }
    }
}
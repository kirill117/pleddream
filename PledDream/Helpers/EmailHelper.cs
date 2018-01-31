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
        public static bool SendMail(string email, string strMessage = "", string subject = "")
        {
            var result = true;
            try
            {
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
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }
    }
}
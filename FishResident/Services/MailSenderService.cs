using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace FishResident.Services
{
    public class MailSenderService : IMailSenderService
    {
        private static string smtpAddress = "smtp.gmail.com";
        private static int portNumber = 587;
        private static bool enableSSL = true;
        private static string emailFromAddress = "rentresident66@gmail.com"; //Sender Email Address  
        private static string password = "SecurePassword123"; //Sender Password  
        public bool MailSend(string reciever, string subject ,string message, string attachmentLink)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFromAddress);
                mail.To.Add(reciever);
                if (subject == null)
                {
                    subject = "Hello!";
                }
                mail.Subject = subject;
                if (message == null)
                {
                    message = "Hello! I try using my new message system!";
                }
                mail.Body = message;
                mail.IsBodyHtml = true;
                if (attachmentLink != null)
                {
                    mail.Attachments.Add(new Attachment(attachmentLink));
                }
                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);
                }
            }
            return true;
        }
    }
}

using System.Net.Mail;

namespace VoorbeeldDiEmailSender
{
    public class EmailSender : IEmailSender
    {
        public void SendEmail(string message)
        {
            using (var smtpClient = new SmtpClient())
            {
                //This will crash since we didn't define an SMTP server
                smtpClient.Send(new MailMessage { Body = message });
            }
        }
    }
}

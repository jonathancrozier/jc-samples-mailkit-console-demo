using System.Net;
using System.Net.Mail;

namespace JC.Samples.MailKitConsoleDemo
{
    /// <summary>
    /// Simple wrapper class around the .NET SmtpClient.
    /// </summary>
    public class DotNetSmtpClient
    {
        #region Methods

        public void SendEmail()
        {
            var message  = new MailMessage();
            message.From = new MailAddress("sender@yourdomain.com", "Sender Name");
            message.To.Add(new MailAddress("recipient@theirdomain.com", "Recipient Name"));
            message.Subject = "SmtpClient Test";
            message.Body    = "Hi from .NET!";

            var client         = new SmtpClient();
            client.Host        = "mail.yoursmtpservice.com";
            client.Port        = 465;
            client.EnableSsl   = true;
            client.Credentials = new NetworkCredential("your_username", "your_password");
            client.Send(message);

            // NOTE: Only works in a .NET Framework project i.e. pre-.NET Core.
            //var smtpSection = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp");
        }

        #endregion
    }
}
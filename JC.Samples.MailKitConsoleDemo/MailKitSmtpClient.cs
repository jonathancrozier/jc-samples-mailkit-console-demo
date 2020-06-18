using MailKit.Net.Smtp;
using MimeKit;

namespace JC.Samples.MailKitConsoleDemo
{
	/// <summary>
	/// Simple wrapper class around the MailKit SmtpClient.
	/// </summary>
	public class MailKitSmtpClient
    {
		#region Methods

		/// <summary>
		/// Sends a test email, using the configured app settings.
		/// </summary>
		public void SendEmail()
		{
			var message = new MimeMessage();
			message.From.Add(new MailboxAddress("Sender Name", "sender@yourdomain.com"));
			message.To.Add(new MailboxAddress("Recipient Name", "recipient@theirdomain.com"));
			message.Subject = "MailKit Test";
			message.Body    = new TextPart("plain") { Text = "Hi from MailKit!" };

			using (var client = new SmtpClient())
			{
				client.Connect("mail.yoursmtpservice.com", 587);
				client.Authenticate("your_username", "your_password");
				client.Send(message);
				client.Disconnect(true);
			}
		}

		#endregion
	}
}
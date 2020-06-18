using System;

namespace JC.Samples.MailKitConsoleDemo
{
	/// <summary>
	/// Main Program class.
	/// </summary>
	class Program
    {
        #region Methods

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">The command-line arguments passed to the program</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Sending test email...");

			var client = new MailKitSmtpClient();
			client.SendEmail();

			Console.WriteLine("Test email sent");
		}

        #endregion
    }
}
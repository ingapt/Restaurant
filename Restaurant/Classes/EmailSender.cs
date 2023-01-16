using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using Restaurant.Interfaces;
using System.Threading.Tasks.Sources;
using Restaurant.Classes.Waitress;

namespace Restaurant.Classes
{
	public class EmailSender : IEmailSender
	{
		public string Host { get; set; }
		public int Port { get; set; }
		public bool EnableSSL { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }

		public string Email { get; set; }

		public EmailSender()
		{
		}

		public void SendEmail(string email, string subject, string htmlMessage)
		{

			var client = new SmtpClient("smtp.mailtrap.io", 2525)
			{
				Credentials = new NetworkCredential("7ac4b1a93592ac", "f1aa74091e0bad"),
				EnableSsl = true
			};
			client.Send("from@example.com", "to@example.com", "Čekis", htmlMessage);
			Console.WriteLine("Čekis išsiųstas klientui.");
			Console.ReadLine();
		}

	}
}

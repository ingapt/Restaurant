namespace Restaurant.Interfaces
{
	public interface IEmailSender
	{
		string Email { get; set; }

		public void SendEmail(string emailstring, string subject, string htmlMessage);
	}
}

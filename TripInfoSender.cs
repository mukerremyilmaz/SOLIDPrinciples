using SOLIDPrinciples.Models;
using System.Net.Mail;

namespace SOLIDPrinciples
{
	public class TripInfoSender
	{
		public async Task SendTripInfoEmailToDriver(DriverInfo driver)
		{
			if (!string.IsNullOrEmpty(driver.EmailAddress))
			{
				var mailMessage = new MailMessage();
				mailMessage.To.Add(driver.EmailAddress);
				var client = new SmtpClient("mail.mailsend.com", 587);
				await client.SendMailAsync(mailMessage);
			}
		}
		public async Task SendTripInfoSmsToDriver(DriverInfo driver)
		{
			if (!string.IsNullOrEmpty(driver.PhoneNumber))
			{
				var smsSender = new SmsSender();
				var sms = new SmsModel()
				{
					Message = "Todays trip",
					PhoneNumber = driver.PhoneNumber,
					SendTime = DateTime.Now
				};
				await smsSender.Send(sms);
			}
		}
	}
}

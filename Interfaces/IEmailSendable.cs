using SOLIDPrinciples.Models;

namespace SOLIDPrinciples.Interfaces
{
	public interface IEmailSendable
	{
		Task SendTripInfoEmailToDriver(DriverInfo driver);
	}
}

using SOLIDPrinciples.Models;

namespace SOLIDPrinciples.Interfaces
{
	public interface ISmsSendable
	{
		Task SendTripInfoSmsToDriver(DriverInfo driver);
	}
}

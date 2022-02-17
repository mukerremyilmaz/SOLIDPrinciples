using SOLIDPrinciples.Models;

namespace SOLIDPrinciples.Interfaces
{
	public interface IMultipleEmailSendable
	{
		Task SendTripInfoEmailToDrivers(List<DriverInfo> drivers);
	}
}

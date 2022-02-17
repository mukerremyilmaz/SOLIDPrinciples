using SOLIDPrinciples.Interfaces;
using SOLIDPrinciples.Models;

namespace SOLIDPrinciples.CarBrands
{
	public class BMW : BaseCar, IEmailSendable, IMultipleEmailSendable
	{
		public override double GetCostPerKM()
		{
			return 1.5;
		}

		public async Task SendTripInfoEmailToDriver(DriverInfo driver)
		{
			TripInfoSender sender = new TripInfoSender();
			await sender.SendTripInfoEmailToDriver(driver);
		}

		public async Task SendTripInfoEmailToDrivers(List<DriverInfo> drivers)
		{
			TripInfoSender sender = new TripInfoSender();
			foreach (DriverInfo driver in drivers)
			{
				await sender.SendTripInfoEmailToDriver(driver);
			}
		}
	}
}

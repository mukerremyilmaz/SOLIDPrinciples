using SOLIDPrinciples.Interfaces;
using SOLIDPrinciples.Models;

namespace SOLIDPrinciples.CarBrands
{
	public class Mercedes : BaseCar, IEmailSendable, ISmsSendable
	{
		public override double GetCostPerKM()
		{
			return 2;
		}

		public void Go()
		{
			Console.WriteLine("Car is now going...");
		}

		public async Task SendTripInfoEmailToDriver(DriverInfo driver)
		{
			TripInfoSender sender = new TripInfoSender();
			await sender.SendTripInfoEmailToDriver(driver);
		}

		public async Task SendTripInfoSmsToDriver(DriverInfo driver)
		{
			TripInfoSender sender = new TripInfoSender();
			await sender.SendTripInfoSmsToDriver(driver);
		}

		public void Stop()
		{
			Console.WriteLine("Car has stopped...");
		}
	}
}

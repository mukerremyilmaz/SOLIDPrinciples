using SOLIDPrinciples;
using SOLIDPrinciples.CarBrands;
using SOLIDPrinciples.CustomExceptions;
using SOLIDPrinciples.Loggers;
using SOLIDPrinciples.Models;

RunCars();
Console.ReadLine();

/*
    S ingle Responsibility Principle  (SRP) - Dar çerçevede bir metodun ya da geniş çerçevede bir modülün sadece tek bir görevle yükümlü olması gerekliliğidir.
    O pen-Close Principle             (OCP) - Modüllerin genişlemeye açık ancak değişime kapalı olması gerekliliğidir. Modüllerde yapılan değişiklikler etkileşimli modülleri etkilememeli.
    L iskov Substitution Principle    (LSP) - Modüllerin türetildiği modüllerin tüm özelliklerini sağlayabilmesi gerekliliğidir.
    I nterface Segregation Principle  (ISP) - Arayüzleri kullanan modüllerin, kullandıkları arayüzlerdeki tüm özellikleri desteklemesi, desteklemiyorsa arayüzlerin ayrılması gerekliliğidir.
    D ependency Inversion Principle   (DIP) - Üst sınıfların alt sınıflara bağımlı olmaması gerekliliğidir.
*/

async void RunCars()
{
	var mercedes = new Mercedes();
	mercedes.Go();
	mercedes.Stop();
	var driver = new DriverInfo()
	{
		EmailAddress = "solid@principles.com",
		FullName = "Solid Principles",
		PhoneNumber = "+905005005050"
	};
	try
	{
		await mercedes.SendTripInfoEmailToDriver(driver);
	}
	catch (EngineStartException exception)
	{
		new TripInfoLogger(new GermanyLogger()).Log(exception.Message);
	}
	catch (AirPressureException exception)
	{
		new TripInfoLogger(new LocalStorageLogger()).Log(exception.Message);
	}
}
void CalculateTripCost(BaseCar car)
{
	var calculator = new FuelCostCalculator();
	var cost = calculator.Calculate(car);
	Console.WriteLine($"Total cost for this car is {cost} TL");
}
namespace SOLIDPrinciples
{
	public abstract class BaseCar
	{
		public int TripKM { get; set; }
		public abstract double GetCostPerKM();
	}
}

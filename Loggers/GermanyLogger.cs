using SOLIDPrinciples.Interfaces;

namespace SOLIDPrinciples.Loggers
{
	public class GermanyLogger : ILogger
	{
		public void Log(string logInfo)
		{
			Console.WriteLine($"Trip info sent to Germany. Trip Info: {logInfo}");
		}
	}
}
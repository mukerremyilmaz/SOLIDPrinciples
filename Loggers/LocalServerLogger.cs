using SOLIDPrinciples.Interfaces;

namespace SOLIDPrinciples.Loggers
{
	public class LocalServerLogger : ILogger
	{
		public void Log(string logInfo)
		{
			Console.WriteLine($"Trip info sent to Local Server. Trip Info: {logInfo}");
		}
	}
}

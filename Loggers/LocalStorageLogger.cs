using SOLIDPrinciples.Interfaces;

namespace SOLIDPrinciples.Loggers
{
	public class LocalStorageLogger : ILogger
	{
		public void Log(string logInfo)
		{
			Console.WriteLine($"Trip info saved into local storage. Trip Info: {logInfo}");
		}
	}
}
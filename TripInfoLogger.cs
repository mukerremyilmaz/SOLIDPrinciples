using SOLIDPrinciples.Interfaces;

namespace SOLIDPrinciples
{
	public class TripInfoLogger
	{
		private readonly ILogger logger;
		public TripInfoLogger(ILogger _logger)
		{
			logger = _logger;
		}
		public void Log(string logInfo)
		{
			logger.Log(logInfo);
		}
	}
}

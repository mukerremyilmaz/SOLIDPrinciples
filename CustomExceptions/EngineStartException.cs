// See https://aka.ms/new-console-template for more information
using System.Runtime.Serialization;

namespace SOLIDPrinciples.CustomExceptions
{
	[Serializable]
	public class EngineStartException : Exception
	{
		public EngineStartException()
		{
		}

		public EngineStartException(string? message) : base(message)
		{
		}

		public EngineStartException(string? message, Exception? innerException) : base(message, innerException)
		{
		}

		protected EngineStartException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
// See https://aka.ms/new-console-template for more information
using System.Runtime.Serialization;
namespace SOLIDPrinciples.CustomExceptions
{
	[Serializable]
	internal class AirPressureException : Exception
	{
		public AirPressureException()
		{
		}

		public AirPressureException(string? message) : base(message)
		{
		}

		public AirPressureException(string? message, Exception? innerException) : base(message, innerException)
		{
		}

		protected AirPressureException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
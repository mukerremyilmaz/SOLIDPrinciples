namespace SOLIDPrinciples.Models
{
	public class SmsModel
	{
		public string PhoneNumber { get; set; }
		public string Message { get; set; }
		public DateTime? SendTime { get; set; }
	}
}
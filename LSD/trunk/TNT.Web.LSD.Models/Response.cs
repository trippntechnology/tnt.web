
namespace TNT.Web.LSD.Models
{
	public class Response<T>
	{
		public bool Success { get; set; }
		public string Message { get; set; }
		public T Payload { get; set; }

		public Response(bool success, T payload, string message = "")
		{
			this.Success = success;
			this.Payload = payload;
			this.Message = message;
		}

		public Response(T payload)
			: this(true, payload)
		{
		}

		public Response(string message)
			: this(false, default(T), message)
		{
		}
	}
}

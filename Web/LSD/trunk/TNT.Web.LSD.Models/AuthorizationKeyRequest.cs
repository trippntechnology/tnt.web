using System;

namespace TNT.Web.LSD.Models
{
	public class AuthorizationKeyRequest
	{
		public string HardwareID { get; set; }
		public Guid ApplicationID { get; set; }
		public string LicenseKey { get; set; }
	}
}

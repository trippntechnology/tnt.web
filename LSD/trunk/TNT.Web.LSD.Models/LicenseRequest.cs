using System;

namespace TNT.Web.LSD.Models
{
	public class LicenseRequest
	{
		public User User { get; set; }
		public Guid ApplicationID { get; set; }
	}
}

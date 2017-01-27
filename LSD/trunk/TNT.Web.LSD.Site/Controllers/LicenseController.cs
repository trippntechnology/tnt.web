using System;
using System.Web.Http;
using TNT.Web.LSD.DAL;
using TNT.Web.LSD.Models;

namespace TNT.Web.LSD.Site.Controllers
{
	public class LicenseController : ApiController
	{
		public Response<License> Post(LicenseRequest request)
		{
			try
			{
				License license = LicenseDAL.GetNewLicense(request.User, request.ApplicationID);
				return new Response<License>(license);
			}
			catch (Exception ex)
			{
				return new Response<License>(ex.Message);
			}
		}
	}
}
